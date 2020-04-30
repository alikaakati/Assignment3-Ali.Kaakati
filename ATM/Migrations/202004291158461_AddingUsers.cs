namespace ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CheckingAccounts(AccountNumber,FirstName,LastName,Balance) VALUES('1234567891','Ali','KaaKati',350) ");
        }
        
        public override void Down()
        {
        }
    }
}
