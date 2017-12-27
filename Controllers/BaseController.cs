using AutoMapper;
using solaire.Models;
namespace solaire.Controllers{
    public class BaseController{
        public readonly IMapper Mapper;
        public AppDbContext DbContext;
        public BaseController(IMapper mapper, AppDbContext dbContext){
            Mapper = mapper;
            DbContext = dbContext;
        }
    }
}