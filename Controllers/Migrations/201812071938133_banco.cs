namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consulta",
                c => new
                    {
                        ID_CONSULTA = c.Int(nullable: false, identity: true),
                        ID_DENTISTA = c.Int(nullable: false),
                        ID_PACIENTE = c.Int(nullable: false),
                        DATA_CONSULTA = c.DateTime(),
                        HORA_MARCADA_CONSULTA = c.DateTime(),
                        HORA_INICIO_CONSULTA = c.DateTime(),
                        HORA_FIM_CONSULTA = c.DateTime(),
                        OBSERVACAO_CONSULTA = c.String(),
                        STATUS_CONSULTA = c.String(),
                    })
                .PrimaryKey(t => t.ID_CONSULTA);
            
            CreateTable(
                "dbo.Dentista",
                c => new
                    {
                        ID_DENTISTA = c.Int(nullable: false, identity: true),
                        NOME_DENTISTA = c.String(),
                        EMAIL_DENTISTA = c.String(),
                        TELEFONE_DENTISTA = c.Long(nullable: false),
                        CELULAR_DENTISTA = c.Long(nullable: false),
                        CRO = c.String(),
                    })
                .PrimaryKey(t => t.ID_DENTISTA);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        ID_PACIENTE = c.Int(nullable: false, identity: true),
                        NOME_PACIENTE = c.String(),
                        EMAIL_PACIENTE = c.String(),
                        TELEFONE_PACIENTE = c.Long(nullable: false),
                        CELULAR_PACIENTE = c.Long(nullable: false),
                        CEP_PACIENTE = c.String(),
                        ENDERECO_PACIENTE = c.String(),
                        COMPLEMENTO_PACIENTE = c.String(),
                        NASCIMENTO_PACIENTE = c.DateTime(nullable: false),
                        SEXO_PACIENTE = c.String(),
                    })
                .PrimaryKey(t => t.ID_PACIENTE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paciente");
            DropTable("dbo.Dentista");
            DropTable("dbo.Consulta");
        }
    }
}
