using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        private int numeroClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;
        private int CPClient;
        private string villeClient;
        private int telClient;
        private string cidtClient;

        public Client()
        {
            numeroClient = 0;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
            CPClient = 0;
            villeClient = "";
            telClient = 0;

        }

        public Client(int numCli)
        {
            numeroClient = numCli;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
            CPClient = 0;
            villeClient = "";
            telClient = 0;

        }

        public Client(int numCli, string nomCli, string prenomCli)
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = "";
            CPClient = 0;
            villeClient = "";
            telClient = 0;
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

        public int getCodePostal()
        {
            return CPClient;
        }

        public string getVilleClient()
        {
            return villeClient;
        }

        public int getTelClient()
        {
            return telClient;
        }

        public string getCidtClient()
        {
            return cidtClient;
        }

        public void setNumeroClient(int num)
        {
            numeroClient = num;
        }

        public void setNomClient(string nom)
        {
            nomClient = nom;
        }

        public void setPrenomClient(string prenom)
        {
            prenomClient = prenom;
        }

        public void setAdresseClient(string adresse)
        {
            adresseClient = adresse;
        }

        public void setCodePostal(int codePostal)
        {
            CPClient = codePostal;
        }

        public void setVilleClient(string ville)
        {
            villeClient = ville;
        }

        public void setTelClient(int numTel)
        {
            telClient = numTel;
        }

        public void setCidtClient(string civilite)
        {
            cidtClient = civilite;
        }
    }
}
