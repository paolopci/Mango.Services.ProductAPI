using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;


namespace Mango.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                // perchè funzioni assicurati che il nome delle proprietà inSource e Target siano le stesse
                config.CreateMap<Product, ProductDto>();
                config.CreateMap<ProductDto, Product>();
            });
            return mappingConfig;
        }
    }
}
