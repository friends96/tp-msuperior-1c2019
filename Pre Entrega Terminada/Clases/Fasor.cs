using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Matematica_Superior_Demo.Services;

namespace TP_Matematica_Superior_Demo.Clases
{
    public abstract class Fasor: IFasor
    {
        public double amplitud;
        public double periodo;
        public double angulo;

        public Fasor(double amplitud, double periodo, double angulo)
        {
            this.amplitud = amplitud;
            this.periodo = periodo;
            this.angulo = angulo;
        }
        public static IFasor CrearFasor(Sinusoidal sinusoide , double amplitud, double periodo, double angulo)
        {
            if (sinusoide == Sinusoidal.COSENO) { return new FasorCoseno(amplitud, periodo, angulo); }
            if (sinusoide == Sinusoidal.SENO) { return new FasorSeno(amplitud, periodo, angulo); }
            throw new InvalidOperationException("poner seno o coseno porfavor");
        }

        public IFasor SumarEnCos(IFasor sumando)
        {
            NumeroComplejoBinomico sumando1 = this.EnCos().EnBinomico();
            NumeroComplejoBinomico sumando2 = sumando.EnCos().EnBinomico();
            INumeroComplejo resultado = OperacionesService.Sumar(sumando1, sumando2);

            return new FasorCoseno(resultado.GetModulo(), this.periodo, resultado.GetArgumento());
        }
        public IFasor SumarEnSen(IFasor sumando)
        {
            NumeroComplejoBinomico sumando1 = this.EnSen().EnBinomico();
            NumeroComplejoBinomico sumando2 = sumando.EnSen().EnBinomico();
            INumeroComplejo resultado = OperacionesService.Sumar(sumando1, sumando2);

            return new FasorCoseno(resultado.GetModulo(), this.periodo, resultado.GetArgumento());
        }
        public virtual IFasor EnCos()
        {
            throw new NotImplementedException();
        }
        public virtual IFasor EnSen()
        {
            throw new NotImplementedException();
        }
        public NumeroComplejoBinomico EnBinomico()
        {
            INumeroComplejo aux = new NumeroComplejoPolar(this.amplitud, this.angulo);//esto es para no repetir la logica de pasar de modulo y angulo a parte real e imaginaria
            return NumeroComplejoBinomico.NewNumeroComplejoBinomico(aux.GetParteReal(), aux.GetParteImaginaria());
        }

        public string Show()
        {
            return $"F(t)= {this.amplitud}*";
        }

    }
    public class FasorSeno : Fasor, IFasor
    {

        public FasorSeno (double amplitud, double periodo, double angulo):base(amplitud,periodo,angulo)
        {
        }

        public override IFasor EnCos()
        {
            return new FasorCoseno(this.amplitud, this.periodo, this.angulo + Math.PI / 2);

        }
        public override IFasor EnSen()
        {
            return this;
        }

    }
    public class FasorCoseno : Fasor, IFasor
    {
        public FasorCoseno(double amplitud, double periodo, double angulo):base( amplitud,  periodo,  angulo)
        {
        }
        public override IFasor EnCos()
        {
            return this;
        }
        public override IFasor EnSen()
        {
            return new FasorCoseno(this.amplitud, this.periodo, this.angulo - Math.PI / 2);
        }
    }

    public enum Sinusoidal
    {
        SENO,
        COSENO
    }
}
