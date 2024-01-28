namespace _10_SQL_formulario.modelo
{
    internal class Venta
    {
        int id;
        string comentarios;
        int idUsuario;

        public Venta()
        {
            this.id = 0;
            this.comentarios=string.Empty;
            this.idUsuario=0;
        }
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Comentarios { get { return this.comentarios; } set {this.comentarios = value; } }
        public int IdUsuario { get { return this.idUsuario; }set { this.idUsuario = value; } }
    }
}
