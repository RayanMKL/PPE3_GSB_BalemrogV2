using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE3_GSB_BalemrogV2
{
    class ControlleurM1
    {
        private static BalemrogBDDEntities maConn;
        public static Visiteur leVisiteurCo;
        public static BalemrogBDDEntities getMaConnexion()
        {
            return maConn;
        }

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConn = new BalemrogBDDEntities();
        }

       /* public static List<Visiteur> listeVisiteur()
        {
            return maConn.Visiteur.ToList();
        }*/

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return "0x"+sb.ToString().ToUpper();
        }
        //Recupere un objet utilisateur en fonction de son id
        public static Visiteur recupVisiteurID(string idV)
        {
            Visiteur unVisiteur = null;
           
                var LQuery = maConn.Visiteur.ToList()
                           .Where(x => x.identifiant == idV);
            if (LQuery.ToList().Count > 0)
            {
                unVisiteur = (Visiteur)LQuery.ToList().First();
            }
                           
            return unVisiteur;
        }

       
        public static int verifierCode(string idV, string mdpV)
        {
            int vretour = 0; //ID mauvais
            
            Visiteur unVisiteur;
            if ((unVisiteur = recupVisiteurID(idV)) != null)
            {
                vretour = 2; // mdp mauvais
                

                // tout est bon
                if (unVisiteur.password.ToString() == GetMd5Hash(mdpV.ToString ()))
                {
                    leVisiteurCo = unVisiteur;
                    vretour = 1; 
                    
                }

            }
            return vretour;
        }


        //Modifier info visiteur
        public static bool ModifVisteur(string nomV, string prenomV, string rueV, string cpV, string villeV, string dateEmbV, string idV)
        {
            bool vretour = true;
            leVisiteurCo.nom = nomV;
            leVisiteurCo.prenom = prenomV;
            leVisiteurCo.rue = rueV;
            leVisiteurCo.cp = cpV;
            leVisiteurCo.ville = villeV;
            leVisiteurCo.dateEmbauche = dateEmbV;
            leVisiteurCo.identifiant = idV;

            try
            {
                maConn.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " " + e.InnerException.InnerException.Message);
                vretour = false;

            }


            return vretour;
        }



        }
}
