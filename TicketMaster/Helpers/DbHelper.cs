namespace Helpers
{
    public static class Helpers
    {
        private static string connectionString = "Host=localhost;Port=5432;Database=TicketMaster;Username=appuser;Password=secret";
        
        private static void CreateTables()
        {
            string evenimentTable = @"CREATE TABLE IF NOT EXISTS Eveniment(
                ID SERIAL PRIMARY KEY,
                ID_OWNER INT NOT NULL,
                nume VARCHAR(100),
                locatie VARCHAR(100),
                descriere TEXT,
                numar_locuri INT
            );";

            string pacheteEvenimenteTable = @"CREATE TABLE IF NOT EXISTS PacheteEvenimente(
                ID SERIAL PRIMARY KEY,
                ID_OWNER INT NOT NULL,
                nume VARCHAR(100),
                locatie VARCHAR(100),
                descriere TEXT
            );";

            string biletPacheteEvenimenteTable = @"CREATE TABLE IF NOT EXISTS BiletPacheteEvenimente(
                COD SERIAL PRIMARY KEY,
                pachet_id INT ,
                eveniment_id INT,

                CONSTRAINT fk_pachet
                    FOREIGN KEY(pachet_id)
                        REFERENCES PacheteEvenimente(ID)
                        ON DELETE CASCADE,

                CONSTRAINT fk_eveniment
                    FOREIGN KEY(eveniment_id)
                        REFERENCES Eveniment(ID)
                        ON DELETE CASCADE
            );";
        }
    }
}