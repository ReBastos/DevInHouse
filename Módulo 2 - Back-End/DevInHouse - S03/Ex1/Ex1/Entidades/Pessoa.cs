namespace Ex1
{
    public class Pessoa
    {

        private string _name;
        private string _birthDate;
        private double _height;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }

        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public string Informations()
        {
            return $"Nome: {_name}; Data de Nascimento: {_birthDate}; Altura {_height};";
        }


    }
}