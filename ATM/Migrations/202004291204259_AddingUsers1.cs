namespace ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CheckingAccounts(AccountNumber,FirstName,LastName,Balance) VALUES('1233211230','Ali','KaaKati',350) ");
        }
        
        public override void Down()
        {
        }
    }
}
