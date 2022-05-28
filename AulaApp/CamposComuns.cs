using System;

namespace AulaApp
{
    public abstract class CamposComuns : CampoDeData
    {
        protected string descricao;

        public string Descricao
        {
            get => this.descricao;
            set => this.descricao = value;
        }

        public CamposComuns() : base()
        {}

        public CamposComuns(string descricao, DateTime data) 
            : base(data)
        {
            this.descricao = descricao;
        }
    } 
}
