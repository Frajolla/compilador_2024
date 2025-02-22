﻿using appCompilador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace appCompilador
{
    public class Lexico : Constants
    {
        private int position;
        private string input;
        private ScannerConstants sc = new ScannerConstants();
        private Form1 form;

        public void SetForm1(Form1 form)
        {
            this.form = form;  
        }
        public Lexico()
        {
            new StringReader("");
        }

        public Lexico(TextReader input)
        {
            setInput(input);
        }

        public void setInput(TextReader input)
        {
            StringBuilder bfr = new StringBuilder();
            try
            {
                int c = input.Read();
                while (c != -1)
                {
                    bfr.Append((char)c);
                    c = input.Read();
                }
                this.input = bfr.ToString();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            setPosition(0);
        }

        public void setPosition(int pos)
        {
            position = pos;
        }

        public Token nextToken() //throws LexicalError
        {
            if (!hasInput())
                return null;

            int start = position;

            int state = 0;
            int lastSate = 0;
            int endEstate = -1;
            int end = -1;

            while (hasInput())
            {
                lastSate = state;
                state = nextState(nextChar(), state);

                if (state < 0)
                    break;

                else
                {
                    if (tokenForState(state) >= 0)
                    {
                        endEstate = state;
                        end = position;
                    }
                }
            }
            
            if (endEstate < 0 || (endEstate != state && tokenForState(lastSate) == -2))
                throw new LexicalError(sc.SCANNER_ERROR[lastSate], start);

            position = end;

            int token = tokenForState(endEstate);



            if (token == 0)
                return nextToken();

            else
            {
                string lexeme = input.Substring(start, end - start);
                lexeme = lexeme.Trim();
                if (lexeme.Equals("="))
                {
                    token = 33;
                    if (this.form.GetNextChar(position).Equals("="))
                    {
                        token = 23;
                        lexeme = "==";
                        position++;
                    }
                }

                token = lookupToken(token, lexeme);
                if (token == 6)
                    throw new LexicalError(sc.SCANNER_ERROR[lastSate], start);
                return new Token(token, lexeme, start);
            }
        }

        private int nextState(char c, int state)
        {
            int start = sc.SCANNER_TABLE_INDEXES[state];
            int end = sc.SCANNER_TABLE_INDEXES[state + 1];

            while (start <= end)
            {
                int half = (start + end) / 2;
                Console.WriteLine($"Checking character: {c}, Table value: {sc.SCANNER_TABLE[half, 0]}");


                if (sc.SCANNER_TABLE[half, 0] == c)
                    return sc.SCANNER_TABLE[half, 1];
                else if (sc.SCANNER_TABLE[half, 0] < c)
                    start = half + 1;
                else  //(ScannerConstants.SCANNER_TABLE[half][0] > c)
                    end = half - 1;
            }

            return -1;
        }

        private int tokenForState(int state)
        {
            if (state < 0 || state >= sc.TOKEN_STATE.Length)
                return -1;

            return sc.TOKEN_STATE[state];
        }

        public int lookupToken(int index, string key)
        {
            int start = sc.SPECIAL_CASES_INDEXES[index];
            int end = sc.SPECIAL_CASES_INDEXES[index + 1] - 1;

            while (start <= end)
            {
                int half = (start + end) / 2;
                int comp = sc.SPECIAL_CASES_KEYS[half].CompareTo(key);

                if (comp == 0)
                    return sc.SPECIAL_CASES_VALUES[half];
                else if (comp < 0)
                    start = half + 1;
                else  //(comp > 0)
                    end = half - 1;
            }

            return index;
        }

        private bool hasInput()
        {
            return position < input.Length;
        }

        private char nextChar()
        {
            if (hasInput())
                return input[position++];
            else
                return '\0';
        }
    }
}