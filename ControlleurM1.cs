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
            return "0x" + sb.ToString().ToUpper();
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
                if (unVisiteur.password.ToString() == GetMd5Hash(mdpV.ToString()))
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

        //Methode recupere toutes les responsabilités par visiteur
        public static Object responsabilitéParVisiteur(string idV)
        {
            var LQuery = maConn.Region.ToList()
                          .Where(x => x.idVisiteur == idV)
                          .Select(x => new { x.idVisiteur, x.libRegion })
                          .OrderBy(x => x.idVisiteur);
            return LQuery.ToList();

        }

        // Methode recupere liste de toutes les regions par secteur
        public static Object regionParSecteur(int idSecteur)
        {
            var LQuery = maConn.Region.ToList()
                          .Where(x => x.idSecteur == idSecteur)
                          .Select(x => new { x.idRegion, x.libRegion, })
                          .OrderBy(x => x.idRegion);
            return LQuery.ToList();

        }
        // Methode recupere liste de toutes les visiteur par region
        public static Object regionParID(int idRegion)
        {
            var LQuery = maConn.Region.ToList()
                          .Where(x => x.idRegion == idRegion)
                          .Select(x => new { x.idRegion, x.libRegion, x.idVisiteur, x.Visiteur ,x.Visiteur1})
                          .OrderBy(x => x.idRegion);
            return LQuery.ToList();

        }


        //Methode Modfier Mot de passe
        public static bool modifierMDP(string nouveauMDP)
        {
            bool vretour = true;

            leVisiteurCo.password = GetMd5Hash(nouveauMDP);

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

        public static List<Secteur> listeSecteur()
        {
            return maConn.Secteur.ToList();
        }

        public static List<Region> listeRegions()
        {
            return maConn.Region.ToList();
        }

        public static List<Laboratoire> listeLabo()
        {
            return maConn.Laboratoire.ToList();
        }

        //Methode verifie si l'utilistateur courant est un responsable
        /* public static bool verifResponsableLabo()
         {

             bool vretour = false;
             foreach(Laboratoire unLab in listeLabo())
             {
                 if(unLab.Visiteur.lis)
             }
             return vretour;
         }

     */

        //Methode veridie si l'utilisateur courant est un responsable de secteur

        public static bool verifResponsableSecteur()
        {
            bool vretour = false;
            foreach (Secteur unSecteur in listeSecteur())
            {
                if (unSecteur.idVisiteur == leVisiteurCo.idVisiteur)
                {
                    vretour = true;
                    break;
                }
            }
            return vretour;
        }

        public static bool verifResponsableRegion()
        {
            bool vretour = false;
            foreach (Region uneRegion in listeRegions())
            {
                if (uneRegion.Visiteur.idVisiteur == leVisiteurCo.idVisiteur)
                {                    
                    vretour = true;
                    break;
                }
            }
            return vretour;
        }

        public static List<Region> listeRegionCourante()
        {          
            return leVisiteurCo.Region1.ToList();
        }

        public static bool modifResponsableRegion(int idRegion, string idVisiteur)
        {
            bool vretour = true;
            Region r = regionParID(idRegion);
            try
            {
                 = idVisiteur;
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
