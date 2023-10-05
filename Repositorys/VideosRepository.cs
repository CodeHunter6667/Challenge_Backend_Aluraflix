using Aluraflix.Context;
using Aluraflix.Models;

namespace Aluraflix.Repositorys;

public class VideosRepository : Repository<Videos>, IVideosRepository
{
    public VideosRepository(AppDbContext context) : base(context)
    {
    }
}
