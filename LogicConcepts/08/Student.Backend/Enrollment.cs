namespace Student.Backend
{
    public class Enrollment
    {
        private int _numberCredits;
        private double _valueCredits;
        private int _stratum;
        private const int _creditLimit = 20;
        public Enrollment(int numberCredits, double valueCredits, int stratum)
        {
            NumberCredits = numberCredits;
            ValueCredits = valueCredits;
            Stratum = stratum;

        }

        public int NumberCredits
        {
            get => _numberCredits;
            set => _numberCredits = GetNumberCredis(value);
        }

        public double ValueCredits
        {
            get => _valueCredits;
            set => _valueCredits = GetValueCredits(value);
        }

        public double BaseCost
        {
            get => CalculateBaseCost();
        }

        public int Stratum
        {
            get => _stratum;
            set => _stratum = GetStratum(value);

        }

        public double FinalCost
        {
            get => CalculateFinalCost();
        }

        private int LimitCredit
        {
            get => _creditLimit;
        }


        public int Subsidy
        {
            get => GetSubsidy(Stratum);
        }

        public override string ToString()
        {
            return $"Número de créditos: {NumberCredits}\nValor crédito: {ValueCredits:C}\nEstrato del estudiante: {Stratum}\n" +
                $"Costo de la matricula: {FinalCost:C}\nValor del subsidio: {Subsidy:C}";
        }



        private int GetNumberCredis(int numberCredits)
        {
            if (numberCredits <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberCredits), "El número de créditos debe de ser mayor a 0");
            }
            return numberCredits;
        }

        private double GetValueCredits(double valueCredits)
        {
            if (valueCredits <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valueCredits), $"El valor de los créditos debe de ser mayor a {0}");
            }
            return valueCredits;
        }

        public double CalculateBaseCost()
        {
            if (NumberCredits <= 20)
            {
                return NumberCredits * ValueCredits;
            }
            else
            {
                return (LimitCredit * ValueCredits) + (((NumberCredits - LimitCredit) * (ValueCredits * 2) ));
            }
            
        }

        private int GetStratum(int stratum)
        {
            if (stratum <= 0 || stratum >= 6)
            {
                throw new ArgumentOutOfRangeException(nameof(stratum), $"El valor del estrato debe estar entre 1 y 6");
            }
            return stratum;
        }

        private double CalculateFinalCost()
        {
            switch (Stratum)
            {
                case 1:
                    return BaseCost - (BaseCost * 0.80);

                case 2:
                    return BaseCost - (BaseCost * 0.50);

                case 3:
                    return BaseCost - (BaseCost * 0.30);

                default:
                    return BaseCost;
            }
        }

        private int GetSubsidy(int stratum)
        {
            if (stratum == 1)
            {
                return 200000;
            }
            else if (stratum == 2)
            {
                return 200000;
            }
            else
            {
                return 0;
            }
        }

    }
}
