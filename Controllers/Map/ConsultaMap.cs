using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            this.ToTable("Consulta");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_CONSULTA");
            this.Property(d => d.IdDentista).HasColumnName("ID_DENTISTA");
            this.Property(d => d.IdPaciente).HasColumnName("ID_PACIENTE");
            this.Property(d => d.Data).HasColumnName("DATA_CONSULTA");
            this.Property(d => d.HoraMarcada).HasColumnName("HORA_MARCADA_CONSULTA");
            this.Property(d => d.HoraInicio).HasColumnName("HORA_INICIO_CONSULTA");
            this.Property(d => d.HoraFim).HasColumnName("HORA_FIM_CONSULTA");
            this.Property(d => d.Observacao).HasColumnName("OBSERVACAO_CONSULTA");
            this.Property(d => d.Status).HasColumnName("STATUS_CONSULTA");
        }
    }
}
