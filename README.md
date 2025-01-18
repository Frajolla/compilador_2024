# Compilador
  Os códigos léxico e sintático foram gerados através do GALS, uma ferramenta geradora de código léxico e semântico. O arquivo com as especificações gramaticais estão em "gals.gals".
  A implementação foi feita utilizando a linguagem C#, aplicando uma GUI e criando as regras semânticas, que após foram convertidas a linguagem de máquina (MSIL - Microsoft Intermediate Language), gerando um objeto executável.

# Linguagem
## Declaração
  Todas as variáveis possuem a tipagem especificada no próprio nome da váriavel, tendo como prefixo:
    -i_ para inteiros
    -f_ para decimais
    -s_ para string
    -b_ para booleanos
## Atribuição:
  Atribuição é feita através do padrão: lista de variáveis = valor correspondente;
  
  exemplos: 

  main
    i_lado1, i_lado2, i_total;
    i_lado1, i_lado2 = 2;
    i_total = i_lado1 * i_lado2;
  end

## Outros exemplos

  main
    s_nome, i_idade;
    read("Digite seu nome: ", s_nome);
    read("Digite sua idade: ", i_idade);
    if i_idade > -1 && i_idade < 120
      writeln("Seja bem vindo ", s_nome, "!");
    elif i_idade < 0
      writeln("Voce nao nasceu ainda? Idade invalida!");
    else
      writeln("Ninguem e tao velho assim! Idade invalida!");
    end;
  end
  
  main
    b_state;
    b_state = False;
