using Layered_Architecture.DataAccessLayer.Abstract;
using Layered_Architecture.DataAccessLayer.Repositories;
using Layered_Architecture.EntityLayer.Concrete;

namespace Layered_Architecture.DataAccessLayer.EntityFramework
{
    public class EFAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
