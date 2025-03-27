namespace listaenlazada1
{
    class LOCOMOTORA
    {
        VAGON primero { get; set; }

        public void AgregaPrimero( int valor) 
        {
            VAGON nuevo = new VAGON(valor);
            if (this.primero == null) // caso 1
            {
                this.primero = nuevo;
            }
            else // caso 2
            {
                VAGON primVag = this.primero;
                nuevo.Sig = this.primero;
                this.primero = nuevo;
               
            }
        }

        public void AgregarFinal(int valor)
        {
            VAGON nuevo = new VAGON(valor);
            if (this.primero == null) // caso 1
            {
                this.primero = nuevo;
            }
            else // caso 2
            {
                VAGON tmp = this.primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }
        }
        public string VerVagones()
        {
            string listadevagones = "";
            VAGON tmp = this.primero;
            while (tmp != null)
            {
                listadevagones += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return listadevagones;
        }

    }
}
