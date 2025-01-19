<h1 style="color:blue;">Compilador</h1>
<p>Os códigos léxico e sintático foram gerados através do GALS, uma ferramenta geradora de código léxico e semântico. O arquivo com as especificações gramaticais está em <code>"gals.gals"</code>.</p>
<p>A implementação foi feita utilizando a linguagem C#, aplicando uma GUI e criando as regras semânticas, que após foram convertidas à linguagem de máquina (<b>MSIL - Microsoft Intermediate Language</b>), gerando um objeto executável.</p>

<h1 style="color:green;">Linguagem</h1>

<h2>Declaração</h2>
<p>Todas as variáveis possuem a tipagem especificada no próprio nome da variável, tendo como prefixo:</p>
<ul>
  <li><code>i_</code> para inteiros</li>
  <li><code>f_</code> para decimais</li>
  <li><code>s_</code> para strings</li>
  <li><code>b_</code> para booleanos</li>
</ul>

<h2>Atribuição</h2>
<p>Atribuição é feita através do padrão: <code>lista de variáveis = valor correspondente;</code></p>

<p><b>Exemplo:</b></p>
<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc;">
main<br>  
    i_lado1, i_lado2, i_total;
    i_lado1, i_lado2 = 2;
    i_total = i_lado1 * i_lado2;<br>
  
end
</pre>

<h2>Outros Exemplos</h2>


<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc;">
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
</pre>

<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc;">
main
    i_num1, i_num2;
    i_num1, i_num2 = 10;
    write(i_num1);
    repeat
      i_num1 = i_num1 - 1;
      write(",", i_num1);
    while i_num1 > 0;
    writeln("");
    write(i_num2);
    repeat
      i_num2 = i_num2 - 1;
      write(",", i_num2);
    until i_num2 == 0;
    writeln("");
    writeln("Programa Finalizado!");
end
</pre>
