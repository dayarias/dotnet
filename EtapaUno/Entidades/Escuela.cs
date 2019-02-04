namespace CoreEscuela.Entidades
{
    class Escuela
    {
       string nombre;
        public string Nombre { 
            
            get {return "Copia: " + nombre; }
            set {nombre = value.ToUpper();}          
         }

         public int AñodeCreacion { get; set; }
         public string Pais { get; set; }
         public string Ciudad { get; set; }

         public TiposEscuela TipoEscuela { get; set; }

        public Escuela (string nombre, int año) => (Nombre, AñodeCreacion) = (nombre, año);

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \nPais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}
