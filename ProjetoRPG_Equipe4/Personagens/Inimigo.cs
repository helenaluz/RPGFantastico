﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRPG_Equipe4.Personagens
{
    internal class Inimigo : Personagem
    {
       /* public int Dificuldade { get; set; } */// equivalente ao nível do inimigo
        /*public int Recompensa { get; set; }*/ // o quanto que desconta do XP dos bonzinhos
        //public enum Tipo;

        public Inimigo(int dificuldade, int recompença, string nome, string sexo) : base(nome, sexo)
        {
            Nivel = dificuldade;
            XP = recompença;
            Defesa = 1;
            PontosVida = 100;
            Sexo = sexo;
            Nome = nome;
            Forca = 70;
            XP = 0;
            Status = "Saudável";
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
        }
    }
}
