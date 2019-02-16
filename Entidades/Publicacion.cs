namespace TareaLibros.Entidades
{
    public abstract class Publicacion
    {
        private string title;
        public string Title
        {
            get { return title;}
            set { title = value;}
        }
        
        private string editionDate;
        public string EditionDate
        {
            get { return editionDate;}
            set { editionDate = value;}
        }
        
        private string editorial;
        public string Editorial
        {
            get { return editorial;}
            set { editorial = value;}
        }
        
        private string autores;
        public string Autores
        {
            get { return autores;}
            set { autores = value;}
        }
        
    }
}