using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csClient2
{
    public class Client
    {
        private int numeroClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;

        public Client()
        {
            numeroClient = 0;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
        }

        public Client(int numCli)
        {
            numeroClient = numCli;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";

        }

        public Client(int numCli, string nomCli, string prenomCli)
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = "";
        }

        public int getNumeroClient()
        {
            return numeroClient;
        }

        public string getNomClient()
        {
            return nomClient;
        }

        public string getPrenomClient()
        {
            return prenomClient;
        }

        public string getAdresseClient()
        {
            return adresseClient;
        }

        public void setNumeroClient(int numCli)
        {

        }

        public void setNomClient(string nomCli)
        {

        }

        public void setPrenomClient(string prenomCli)
        {

        }

        public void setAdresseClient(string adresseCli)
        {

        }
    }
}
