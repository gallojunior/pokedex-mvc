using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data;

public class AppDbSeed
{

    public AppDbSeed(ModelBuilder builder)
    {
        #region Seed Tipo
        List<Tipo> tipos = new() {
            new Tipo() {
                Id = 1,
                Nome = "Aço",
                Cor = "rgba(170, 170, 187, 1)"
            },
            new Tipo() {
                Id = 2,
                Nome = "Água",
                Cor = "rgba(51, 153, 255, 1)"
            },
            new Tipo() {
                Id = 3,
                Nome = "Dragão",
                Cor = "rgba(119, 102, 238, 1)"
            },
            new Tipo() {
                Id = 4,
                Nome = "Elétrico",
                Cor = "rgba(255, 204, 51, 1)"
            },
            new Tipo() {
                Id = 5,
                Nome = "Fada",
                Cor = "rgba(238, 153, 238, 1)"
            },
            new Tipo() {
                Id = 6,
                Nome = "Fantasma",
                Cor = "rgba(102, 102, 187, 1)"
            },
            new Tipo() {
                Id = 7,
                Nome = "Fogo",
                Cor = "rgba(255, 68, 34, 1)"
            },
            new Tipo() {
                Id = 8,
                Nome = "Gelo",
                Cor = "rgba(102, 204, 255, 1)"
            },
            new Tipo() {
                Id = 9,
                Nome = "Inseto",
                Cor = "rgba(170, 187, 34, 1)"
            },
            new Tipo() {
                Id = 10,
                Nome = "Lutador",
                Cor = "rgba(187, 85, 68, 1)"
            },
            new Tipo() {
                Id = 11,
                Nome = "Normal",
                Cor = "rgba(170, 170, 153, 1)"
            },
            new Tipo() {
                Id = 12,
                Nome = "Pedra",
                Cor = "rgba(187, 170, 102, 1)"
            },
            new Tipo() {
                Id = 13,
                Nome = "Planta",
                Cor = "rgba(119, 204, 85, 1)"
            },
            new Tipo() {
                Id = 14,
                Nome = "Psíquico",
                Cor = "rgba(255, 85, 153, 1)"
            },
            new Tipo() {
                Id = 15,
                Nome = "Sombrio",
                Cor = "rgba(119, 85, 68, 1)"
            },
            new Tipo() {
                Id = 16,
                Nome = "Terrestre",
                Cor = "rgba(221, 187, 85, 1)"
            },
            new Tipo() {
                Id = 17,
                Nome = "Venenoso",
                Cor = "rgba(170, 85, 153, 1)"
            },
            new Tipo() {
                Id = 18,
                Nome = "Voador",
                Cor = "rgba(136, 153, 255, 1)"
            }
        };
        builder.Entity<Tipo>().HasData(tipos);
        #endregion

        #region Seed Genero
        List<Genero> generos = new() {
            new Genero() {
                Id = 1,
                Nome = "Masculino"
            },
            new Genero() {
                Id = 2,
                Nome = "Feminino"
            },
            new Genero() {
                Id = 3,
                Nome = "Masculino e Feminino"
            },
            new Genero() {
                Id = 4,
                Nome = "Desconhecido"
            }
        };
        builder.Entity<Genero>().HasData(generos);
        #endregion
    
        #region Seed Regiao
        List<Regiao> regioes = new() {

        };
        builder.Entity<Regiao>().HasData(regioes);
        #endregion
    }

}
