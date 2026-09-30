                C# Conversion
                     ?
          ???????????????????????
          ?                     ?
      Implicit              Explicit
          ?                     ?
   C# does it             You tell C#
   automatically          it to convert
          ?                     ?
      int ? long            long ? int
      long q = 15488;       (int)x ? int q = (int)x;


                Conversion Tools
                       ?
                 ?????????????
                 ?           ?
              Convert      Parse/
              methods      TryParse
                ?
                ??? ToInt32()
                ??? ToInt64()
                ??? ToDouble()
                ??? ToDecimal()
                ??? ToBoolean()
                ??? ToString()
                ??? ToDateTime()

. Convert class: a static class with methods such as ToInt32(), ToDouble(), ToBoolean(), etc.
. Convert can throw exceptions such as FormatException and OverflowException.
. Don't confuse explicit casting with using Convert.