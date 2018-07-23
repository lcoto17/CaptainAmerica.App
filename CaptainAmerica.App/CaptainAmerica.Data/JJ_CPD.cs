namespace CaptainAmerica.Data
{
    using CaptainAmerica.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class JJ_CPD : DbContext
    {
        // Your context has been configured to use a 'JJ_CPD' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CaptainAmerica.Data.JJ_CPD' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JJ_CPD' 
        // connection string in the application configuration file.
        public JJ_CPD()
            : base("name=JJ_CPD")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Proyecto> dbProyecto { get; set; }
        public virtual DbSet<Cliente> dbCliente { get; set; }
        public virtual DbSet<ProyectoArchivo> dbProyectoArchivo { get; set; }
        public virtual DbSet<ProyectoCategoria> dbProyectoCategoria { get; set; }
        public virtual DbSet<ProyectoMiembro> dbProyectoMiembro { get; set; }
        public virtual DbSet<ArchivoComentario> dbArchivoComentario { get; set; }
        public virtual DbSet<Usuario> dbUsuario { get; set; }
        public virtual DbSet<Rol> dbRol { get; set; }
    }

}