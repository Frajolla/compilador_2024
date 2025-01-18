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
  
    s_nome;
    read("Digite seu nome: ", s_nome);
    if nome == "Carlos"
      writeln("Seja bem vindo Carlos!");
    elif nome == "Carla"
      writeln("Seja bem vinda Carla!");
    else:
      writeln("Seja bem vindo " + s_nome);
    end;
    
  end
