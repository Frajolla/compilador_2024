<h1 style="color:blue;">Compilador</h1>
<p>Os códigos léxico e sintático foram gerados através do GALS, uma ferramenta geradora de código léxico e sintático. O arquivo com as especificações gramaticais estão em <code>gals.gals</code>.</p>
<p>A implementação foi feita utilizando a linguagem C#, aplicando uma GUI e criando as regras semânticas, que após foram convertidas à linguagem de máquina (<b>MSIL - Microsoft Intermediate Language</b>), gerando um objeto executável.</p>

<h2>Instruções</h2>
<p>1. Execute o programa através da pasta <code>bin/Debug/net8.0-windows</code> ou diretamente por uma IDE.</p>
<p>2. Digite o código desejado de acordo com a linguagem apresentada na próxima sessão.</p>
<p>3. Salve o arquivo em um diretório.</p>
<p>4. Compile a programa pelo botão <code>Compilar</code> ou pela tecla de atalho F7.</p>
<p>5. Para executar o programa abra o prompt de comandos e acesse o diretório onde um arquivo <code>.il</code> foi gerado na compilação do programa.</p>
<p>6. Digite <code>C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ilasm exemplo.il</code>, onde exemplo.il será o nome do arquivo salvo.</p>
<p>7. Digite <code>exemplo.exe</code> para executar o arquivo.</p>
<br>
<h1">Linguagem</h1>
<br>
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
<h2>Comentários de bloco</h2>
<p>Segue o padrão: >@[Tabulação vertical][Texto desejado, sem espaços no final][Tabulação vertical]@<
<p><b>Exemplo:</b></p>
>@
    Comentário de bloco
@<
                                                                                                      
<h2>Outros Exemplos</h2>
<br>
Comandos de leitura e seleção:
<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc;">
main<br>
    s_nome, i_idade;<br>
    read("Digite seu nome: ", s_nome);
    read("Digite sua idade: ", i_idade);<br>    
    if i_idade > -1 && i_idade < 120
      writeln("Seja bem vindo ", s_nome, "!");
    elif i_idade < 0
      writeln("Voce nao nasceu ainda? Idade invalida!");
    else
      writeln("Ninguem e tao velho assim! Idade invalida!");
    end;<br>
end
</pre>
<br>
Comandos de repetição:
<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc;">
main<br>
    i_num1, i_num2;
    i_num1, i_num2 = 10;<br>
    write(i_num1);
    repeat
      i_num1 = i_num1 - 1;
      write(",", i_num1);
    while i_num1 > 0;<br>
    writeln("");
    write(i_num2);
    repeat
      i_num2 = i_num2 - 1;
      write(",", i_num2);
    until i_num2 == 0;<br>
    writeln("");
    writeln("Programa Finalizado!");<br>
end
</pre>
<br>
Expressões aritméticas
<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc;">
main<br>
  i_baseMaior, i_baseMenor, i_altura, f_area;

  read (i_baseMaior, i_baseMenor, i_altura);
  f_area = (i_baseMaior + i_baseMenor ) * i_altura / 2;
  write (f_area);

end
</pre>
