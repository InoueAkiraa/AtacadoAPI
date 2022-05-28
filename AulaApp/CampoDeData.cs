using System;

namespace AulaApp
{
    public abstract class CampoDeData
    {
        protected DateTime dataDeInsercao;

        public DateTime DataDeInsercao
        {
            get => this.dataDeInsercao;
            set => this.dataDeInsercao = value;
        }

        public CampoDeData()
        {}

        public CampoDeData(DateTime data){
            this.dataDeInsercao = data;
        }
    }
}
