using DataAccess;
using Models;

namespace BusinessLogic
{
    public class VareBL
    {
        VareDA db;

        public VareBL()
        {
            db=new VareDA();
        }
        public List<Vare> Get()
        {
            return db.Get();
        }
        public bool TryGetVare(int id, out Vare vare)
        {
            vare = db.Get(id);
            return (vare != null);
        }
        public bool Create(Vare vare)
        {
            return db.Create(vare);
        }
        public bool Update(Vare vare)
        {
            return db.Update(vare);
        }
        public bool Delete(int id)
        {
            return db.Delete(id);
        }
    }
}