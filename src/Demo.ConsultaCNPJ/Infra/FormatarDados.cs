using Demo.ConsultaCNPJ.Models;
using System;

namespace Demo.ConsultaCNPJ.Infra
{
    public class FormatarDados
    {
        public static Empresa MontarObjEmpresa(string cnpj, string resp)
        {
            var empresa = new Empresa(
                cnpj, recuperaColunaValor(resp, Coluna.RazaoSocial),
                recuperaColunaValor(resp, Coluna.NomeFantasia),
                recuperaColunaValor(resp, Coluna.EnderecoLogradouro) + recuperaColunaValor(resp, Coluna.EnderecoNumero),
                recuperaColunaValor(resp, Coluna.EnderecoBairro),
                recuperaColunaValor(resp, Coluna.EnderecoCEP),
                recuperaColunaValor(resp, Coluna.AtividadeEconomicaPrimaria),
                recuperaColunaValor(resp, Coluna.EnderecoCidade),
                recuperaColunaValor(resp, Coluna.EnderecoEstado)
            );

            return empresa;
        }

        private static string recuperaColunaValor(string pattern, Models.Coluna col)
        {
            var s = pattern.Replace("\n", "").Replace("\t", "").Replace("\r", "");

            switch (col)
            {
                case Coluna.RazaoSocial:
                    {
                        s = stringEntreString(s, "<!-- Início Linha NOME EMPRESARIAL -->", "<!-- Fim Linha NOME EMPRESARIAL -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.NomeFantasia:
                    {
                        s = stringEntreString(s, "<!-- Início Linha ESTABELECIMENTO -->", "<!-- Fim Linha ESTABELECIMENTO -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.NaturezaJuridica:
                    {
                        s = stringEntreString(s, "<!-- Início Linha NATUREZA JURÍDICA -->", "<!-- Fim Linha NATUREZA JURÍDICA -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.AtividadeEconomicaPrimaria:
                    {
                        s = stringEntreString(s, "<!-- Início Linha ATIVIDADE ECONOMICA -->", "<!-- Fim Linha ATIVIDADE ECONOMICA -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.AtividadeEconomicaSecundaria:
                    {
                        s = stringEntreString(s, "<!-- Início Linha ATIVIDADE ECONOMICA SECUNDARIA-->", "<!-- Fim Linha ATIVIDADE ECONOMICA SECUNDARIA -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.NumeroDaInscricao:
                    {
                        s = stringEntreString(s, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.MatrizFilial:
                    {
                        s = stringEntreString(s, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringSaltaString(s, "</b>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.EnderecoLogradouro:
                    {
                        s = stringEntreString(s, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.EnderecoNumero:
                    {
                        s = stringEntreString(s, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringSaltaString(s, "</b>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.EnderecoComplemento:
                    {
                        s = stringEntreString(s, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringSaltaString(s, "</b>");
                        s = stringSaltaString(s, "</b>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.EnderecoCEP:
                    {
                        s = stringEntreString(s, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.EnderecoBairro:
                    {
                        s = stringEntreString(s, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringSaltaString(s, "</b>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.EnderecoCidade:
                    {
                        s = stringEntreString(s, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringSaltaString(s, "</b>");
                        s = stringSaltaString(s, "</b>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.EnderecoEstado:
                    {
                        s = stringEntreString(s, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringSaltaString(s, "</b>");
                        s = stringSaltaString(s, "</b>");
                        s = stringSaltaString(s, "</b>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.SituacaoCadastral:
                    {
                        s = stringEntreString(s, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.DataSituacaoCadastral:
                    {
                        s = stringEntreString(s, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringSaltaString(s, "</b>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }
                case Coluna.MotivoSituacaoCadastral:
                    {
                        s = stringEntreString(s, "<!-- Início Linha MOTIVO DE SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha MOTIVO DE SITUAÇÃO CADASTRAL -->");
                        s = stringEntreString(s, "<tr>", "</tr>");
                        s = stringEntreString(s, "<b>", "</b>");
                        return s.Trim();
                    }

                default:
                    {
                        return s;
                    }
            }
        }

        private static string stringEntreString(string str, string strInicio, string strFinal)
        {
            var ini = str.IndexOf(strInicio);
            var fim = str.IndexOf(strFinal);

            if (ini > 0)
                ini = ini + strInicio.Length;

            if (fim > 0)
                fim = fim + strFinal.Length;

            var diff = ((fim - ini) - strFinal.Length);
            if ((fim > ini) && (diff > 0))
                return str.Substring(ini, diff);
            else
                return string.Empty;
        }

        private static string stringSaltaString(string str, string strInicio)
        {
            var ini = str.IndexOf(strInicio);

            if (ini > 0)
            {
                ini = ini + strInicio.Length;
                return str.Substring(ini);
            }
            else
                return str;
        }

        private string stringPrimeiraLetraMaiuscula(string str)
        {
            return
                str.Length > 0 ?
                    str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1).ToLower() :
                    string.Empty;

        }
    }
}