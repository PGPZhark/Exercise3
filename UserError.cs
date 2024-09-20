using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal abstract class UserError
    {

        public abstract string UEMessage();

    }

    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    internal class TooLargeInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to input something larger than the set limit. This fired an error!";
        }
    }

    internal class TooSmallInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to input something smaller than the set limit. This fired an error!";
        }
    }

    
    internal class NonIntegerInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a non whole number for something that requires a whole number. This fired an error!";
        }
    }
    
}
