using SOLID.Models;

namespace SOLID.Services
{
    public interface IAdminService
    {
        IEnumerable<Categoria> GetAllCategory();
        IEnumerable<Leilao> GetAllAuctions();
        Leilao GetAuction(int id);
        void InsertAuction(Leilao auction);
        void UpdateAuction(Leilao auction);
        void DeleteAuction(Leilao auction);
        void StartAuctionSessionWithId(int id);
        void FinishAuctionSessionWithId(int id);
    }
}
