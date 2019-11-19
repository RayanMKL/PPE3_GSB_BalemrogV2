using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_GSB_BalemrogV2
{
    public static class ControlleurM2
    {
        private static BalemrogBDDEntities maCo;
        public static RAPPORT LeRapport;
        public static void init()
        {
            maCo = new BalemrogBDDEntities();
        }

        public static List<MEDECIN> listepracticien()
        {
            return maCo.MEDECIN.ToList();
        }

        public static List<MOTIF> listemotif()
        {
            return maCo.MOTIF.ToList();
        }
        public static List<SPECIALITE> listespecialite()
        {
            return maCo.SPECIALITE.ToList();
        }

        public static List<OFFRIR> listeoffrir()
        {
            return maCo.OFFRIR.ToList();
        }

        public static void trouverRapport(int id)
        {
            var Lquery = maCo.RAPPORT.ToList()
                .Where(x => x.idRapport == id);

            LeRapport = (RAPPORT)Lquery.ToList().First();
        }
        public static List<RAPPORT> listerapport()
        {
            return maCo.RAPPORT.ToList();
        }

        public static Object Medocs()
        {
            var LQuery = maCo.OFFRIR.ToList()
                           .Select(x => new { x.idMedicament, x.quantite })
                           .OrderBy(x => x.idMedicament);
            return LQuery.ToList();
        }
    }
}
