using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuharjoCore.Models
{
    public class ModelMap
    {
        public ModelMap(EntityTypeBuilder<Category> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name_Category).IsRequired();
        }
        public ModelMap(EntityTypeBuilder<Item> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.Price).IsRequired();
            entityTypeBuilder.Property(t => t.Stock).IsRequired();
            entityTypeBuilder.Property(t => t.Description).IsRequired();
            entityTypeBuilder.Property(t => t.CategoryID).IsRequired();


        }
    }
}
