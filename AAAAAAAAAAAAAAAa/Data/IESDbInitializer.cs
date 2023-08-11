﻿using AAAAAAAAAAAAAAAa.Models;
using System.Linq;

namespace AAAAAAAAAAAAAAAa.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();
            if (context.Departamentos.Any())
            {
                return;
            }
            var departamentos = new Departamento[]
            {
                new Departamento { Nome="Ciência da Computação"},
                new Departamento { Nome="Ciência de Alimentos"}
            };
            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();
            
            context.Database.EnsureCreated();
            if (context.Instituicoes.Any())
            {
                return;
            }
            var instituicoes = new Instituicao[]
            {
                new Instituicao { Nome="Ciência da Computação",
                                    Endereco="Rua LALA"},
                new Instituicao { Nome="Ciência de Alimentos",
                                    Endereco="Rua LeLe"}
            };
            foreach (Instituicao i in instituicoes)
            {
                context.Instituicoes.Add(i);
            }
            context.SaveChanges();
        }
    }
}
