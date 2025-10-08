using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TirsvadWeb.Wasm.ProjectDocs.WebUI.Data;

namespace TirsvadWeb.Wasm.ProjectDocs.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
}
