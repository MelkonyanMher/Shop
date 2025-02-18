﻿using AutoMapper;
using Tionit.MyShop.Domain;

namespace Tionit.MyShop.Admin.Application.Queries.OrderItems.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderItemModel
    {
        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Количество товара
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Обшяя сумаа товара
        /// </summary>
        public double TotalSum => Price * Quantity;

        internal class MappingProfile: Profile
        {
            public MappingProfile()
            {
                var mapping = CreateMap<OrderItem, OrderItemModel>();
                mapping.ForMember(model => model.Name, opts => opts.MapFrom(oi => oi.Product.Name));
                mapping.ForMember(model => model.Price, opts => opts.MapFrom(oi => oi.Product.Price));
                mapping.ForMember(model => model.Quantity, opts => opts.MapFrom(oi => oi.Quantity));
            }
        }
    }
}
