using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Rinse-Off Eye Makeup Remover",
                    Description =
                        "A unique formula that quickly removes all makeup, from your lashes to your brows.",
                    Price = 32,
                    PictureUrl = "/images/products/clinique-remover.jpeg",
                    Brand = "CLINIQUE",
                    Type = "Make-Up Remover",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Cleansing Foam Face Cleanser",
                    Description = "A cleansing foam that contains sea algae fibers and white pearl powder, which gently purify and energize skin.",
                    Price = 144,
                    PictureUrl = "/images/products/lamer-cleanser.jpeg",
                    Brand = "LA MER",
                    Type = "Cleanser",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Treatment Lotion",
                    Description =
                        "A super hydrator that optimizes your La Mer regimen with a fast-absorbing formula that delivers an instant rush of hydration to skin.",
                    Price = 250,
                    PictureUrl = "/images/products/lamer-lotion.jpeg",
                    Brand = "LA MER",
                    Type = "Lotion",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Moisturizing Soft Cream",
                    Description =
                        "An ultra-soft hydrating cream to reduce look of fine dry lines.",
                    Price = 804,
                    PictureUrl = "/images/products/lamer-cream.jpeg",
                    Brand = "LA MER",
                    Type = "Cream",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "All About Eyes™ Rich Eye Cream",
                    Description =
                        "A moisture-rich eye cream that helps diminish the look of under-eye circles, shadows, puffiness and fine lines.",
                    Price = 88,
                    PictureUrl = "/images/products/clinique-eye-cream.jpeg",
                    Brand = "CLINIQUE",
                    Type = "Eye Cream",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Skin Caviar Luxe Sleep Mask",
                    Description =
                        "A luxe sleep mask remastered with the newest incarnation of caviar that delivers an exquisite moment of indulgence, melting instantly into skin.",
                    Price = 12000,
                    PictureUrl = "/images/products/la-prairie-mask.jpeg",
                    Brand = "LA PRAIRIE",
                    Type = "Mask",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Skin Caviar Luxe Cream Sheer",
                    Description =
                        "A cream remastered with the newest incarnation of caviar has a delightfully delicate texture that provides legendary lifting and firming in a sheer formula.",
                    Price = 1465,
                    PictureUrl = "/images/products/la-prairie-cream.jpeg",
                    Brand = "LA PRAIRIE",
                    Type = "Cream",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Skin Caviar Nighttime Oil",
                    Description =
                        "An indulgent line-smoothing facial oil imbued with La Prairie's newest caviar incarnation, caviar retinol.",
                    Price = 805,
                    PictureUrl = "/images/products/la-prairie-moisturizer.jpeg",
                    Brand = "LA PRAIRIE",
                    Type = "Moisturizer",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Concentrate",
                    Description =
                        "A potent barrier serum with a concentrated form of cell-renewing Miracle Broth™ for skin that’s stronger, more stable and visibly soothed.",
                    Price = 835,
                    PictureUrl = "/images/products/lamer-serum.jpeg",
                    Brand = "LA MER",
                    Type = "Serum",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ultra Facial Cream",
                    Description =
                        "A facial cream that hydrates and smoothes skin while providing 24-hour moisturization.",
                    Price = 88,
                    PictureUrl = "/images/products/kiehls-cream.jpeg",
                    Brand = "KIEHL'S SINCE 1851",
                    Type = "Cream",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Moisture Surge Overnight Mask",
                    Description =
                        "A creamy, penetrating night mask that helps skin drink deep to replenish lost moisture and build reserves for tomorrow.",
                    Price = 56,
                    PictureUrl = "/images/products/clinique-mask.jpeg",
                    Brand = "CLINIQUE",
                    Type = "Mask",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Rose Deep Hydration Sleeping Mask",
                    Description =
                        "A two-step mask that delivers continuous hydration overnight for supple, dewy skin by drenching your face with moisture then locking it in.",
                    Price = 76,
                    PictureUrl = "/images/products/fresh-mask.jpeg",
                    Brand = "FRESH",
                    Type = "Mask",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Benefiance Wrinkle Smoothing Eye Cream",
                    Description =
                        "An anti-aging eye cream that hydrates and visibly corrects wrinkles in just one week.",
                    Price = 97,
                    PictureUrl = "/images/products/shiseido-eye-cream.jpeg",
                    Brand = "SHISEIDO",
                    Type = "Eye Cream",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ultra Facial Cleanser",
                    Description =
                        "A gentle face wash that helps lift away dirt and excess oil without over-drying skin.",
                    Price = 33,
                    PictureUrl = "/images/products/kiehls-cleanser.jpeg",
                    Brand = "KIEHL'S SINCE 1851",
                    Type = "Cleanser",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Rose & Hyaluronic Acid Deep Hydration Moisturizer",
                    Description =
                        "A best-selling hyaluronic-acid moisturizer that delivers up to 72 hours of deep hydration to skin.",
                    Price = 68,
                    PictureUrl = "/images/products/fresh-moisturizer.jpeg",
                    Brand = "FRESH",
                    Type = "Moisturizer",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Eye Concentrate Eye Cream",
                    Description =
                        "A hydrating eye cream to help rapidly reduce the appearance of dark circles, smooth fine lines and wrinkles and prevent further damage.",
                    Price = 372,
                    PictureUrl = "/images/products/lamer-eye-cream.jpeg",
                    Brand = "LA MER",
                    Type = "Eye Cream",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lotus Anti-Aging Night Moisturizer",
                    Description = "A lightweight antioxidant night cream that recovers and detoxifies skin while helping to minimize signs of aging.",
                    Price = 79,
                    PictureUrl = "/images/products/fresh-moisturizer.jpeg",
                    Brand = "FRESH",
                    Type = "Moisturizer",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Instant Eye Make-Up Remover",
                    Description =
                        "An ultra-gentle bi-phase makeup remover.",
                    Price = 46,
                    PictureUrl = "/images/products/clarins-remover.jpeg",
                    Brand = "CLARINS",
                    Type = "Make-Up Remover",
                    QuantityInStock = 100
                },

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}