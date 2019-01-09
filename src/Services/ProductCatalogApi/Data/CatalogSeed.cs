using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data;
using ProductCatalogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanardEShop.Services.ProductCatalogApi.Data
{
    public class CatalogSeed
    {


        public static async Task SeedAsync(CatalogContext context)
        {
            context.Database.Migrate();
            if (!context.CatalogBrands.Any())
            {
                context.CatalogBrands.AddRange(GetPreconfiguredCatalogBrands());
                await context.SaveChangesAsync();
            }
            if (!context.CatalogTypes.Any())
            {
                context.CatalogTypes.AddRange(GetPreconfiguredCatalogTypes());
                await context.SaveChangesAsync();
            }

            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(GetPreconfiguredItems());
                await context.SaveChangesAsync();
            }

        }

        static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new CatalogBrand() { Brand = "Canard"},
                new CatalogBrand() { Brand = "Puma" },
                new CatalogBrand() { Brand = "Crocodile" },
                new CatalogBrand() { Brand = "Lapin" }

            };
        }

        static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() { Type = "T-Shirt"},
                new CatalogType() { Type = "Polo" },
                new CatalogType() { Type = "Débardeur" },

            };
        }
        static IEnumerable<CatalogItem> GetPreconfiguredItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Blanc - Burnt", Name = "Blanc - Burnt", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Blanc - Jaune", Name = "Blanc - Jaune", Price= 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Blanc - Noir", Name = "Blanc - Noir", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Blanc - Orange", Name = "Blanc - Orange", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Burnt - Blanc", Name = "Burnt - Blanc", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Jaune - Blanc", Name = "Jaune - Blanc", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Jaune - Orange", Name = "Jaune - Orange", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7"  },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Noir - Blanc", Name = "Noir - Blanc", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Noir - Jaune", Name = "Noir - Jaune", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Orange - Blanc", Name = "Orange - Blanc", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Orange - Jaune", Name = "Orange - Jaune", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=1, Description = "Orange - Bleu - Blanc", Name = "Orange - Bleu - Blanc", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=3, Description = "Orange - Blanc", Name = "Orange - Blanc", Price = 50, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=4, Description = "Lapin classe", Name = "Classe", Price = 500, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new CatalogItem() { CatalogTypeId=1,CatalogBrandId=2, Description = "Puma gris", Name = "Gris", Price = 15, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=4, Description = "Polo gris foncé", Name = "Gris foncé", Price = 500, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=2, Description = "Polo gris clair", Name = "Gris clair", Price = 12, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17" },
                new CatalogItem() { CatalogTypeId=2,CatalogBrandId=3, Description = "Polo Orange - Bleu - Blanc", Name = "Orange - Bleu - Blanc", Price = 100, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/18" },
                new CatalogItem() { CatalogTypeId=3,CatalogBrandId=2, Description = "Débardeur bleu", Name = "Bleu", Price = 12, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/19" }

            };
        }


    }
}
