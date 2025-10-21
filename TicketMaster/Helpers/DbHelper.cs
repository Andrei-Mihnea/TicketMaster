namespace Helpers
{
    public static class Helpers
    {
        private static string connectionString =
            "Host=localhost;Port=5432;Database=TicketMaster;Username=appuser;Password=secret";

        private static string evenimentTable = string.Empty;
        private static string pachetTable = string.Empty;
        private static string pachetEvenimentTable = string.Empty;
        private static string biletTable = string.Empty;

        private static void CreateTables()
        {
            evenimentTable = @"
                CREATE TABLE IF NOT EXISTS Eveniment (
                    id SERIAL PRIMARY KEY,
                    id_owner INT NOT NULL,
                    nume VARCHAR(100) NOT NULL,
                    locatie VARCHAR(100),
                    descriere TEXT,
                    numar_locuri INT,
                    CONSTRAINT unq_eveniment_owner_nume UNIQUE (id_owner, nume) -- nume unic per owner
                );";

            pachetTable = @"
                CREATE TABLE IF NOT EXISTS Pachet (
                    id SERIAL PRIMARY KEY,
                    id_owner INT NOT NULL,
                    nume VARCHAR(100) NOT NULL,
                    locatie VARCHAR(100),
                    descriere TEXT,
                    CONSTRAINT unq_pachet_owner_nume UNIQUE (id_owner, nume) -- nume unic per owner
                );";

            pachetEvenimentTable = @"
                CREATE TABLE IF NOT EXISTS PachetEveniment (
                    pachet_id   INT NOT NULL,
                    eveniment_id INT NOT NULL,
                    numar_locuri INT NULL,
                    PRIMARY KEY (pachet_id, eveniment_id),
                    CONSTRAINT fk_pe_pachet
                        FOREIGN KEY (pachet_id) REFERENCES Pachet(id) ON DELETE CASCADE,
                    CONSTRAINT fk_pe_eveniment
                        FOREIGN KEY (eveniment_id) REFERENCES Eveniment(id) ON DELETE CASCADE
                );";

            biletTable = @"
                CREATE TABLE IF NOT EXISTS Bilet (
                    cod VARCHAR(64) PRIMARY KEY,
                    pachet_id INT NULL,
                    eveniment_id INT NOT NULL,
                    CONSTRAINT fk_bilet_pachet
                        FOREIGN KEY (pachet_id) REFERENCES Pachet(id) ON DELETE SET NULL,
                    CONSTRAINT fk_bilet_eveniment
                        FOREIGN KEY (eveniment_id) REFERENCES Eveniment(id) ON DELETE CASCADE
                );";
        }
    }
}
