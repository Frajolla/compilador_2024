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
main
    i_lado1, i_lado2, i_total;
    i_lado1, i_lado2 = 2;
    i_total = i_lado1 * i_lado2;
end
</pre>

<h2>Outros Exemplos</h2>

```python
<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc; color:#333;">
<span style="color:blue;">main</span>
  
    <span>s_nome</span>, <span>i_idade</span>;
  
    <span style="color:purple;">read</span>(<span style="color:light-green;">"Digite seu nome: "</span>, <span>s_nome</span>);
    <span style="color:purple;">read</span>(<span style="color:light-green;">"Digite sua idade: "</span>, <span>i_idade</span>);
  
    <span style="color:blue;">if</span> <span style="color:purple;">i_idade</span> > -1 && <span style="color:purple;">i_idade</span> < 120
      <span style="color:green;">writeln</span>(<span style="color:orange;">"Seja bem vindo "</span>, <span style="color:purple;">s_nome</span>, <span style="color:orange;">"!"</span>);
    <span style="color:blue;">elif</span> <span style="color:purple;">i_idade</span> < 0
      <span style="color:green;">writeln</span>(<span style="color:orange;">"Voce nao nasceu ainda? Idade invalida!"</span>);
    <span style="color:blue;">else</span>
      <span style="color:green;">writeln</span>(<span style="color:orange;">"Ninguem e tao velho assim! Idade invalida!"</span>);
    <span style="color:blue;">end</span>;
      
<span style="color:blue;">end</span>
</pre>

<pre style="background-color:#f4f4f4;padding:10px;border-left:5px solid #ccc; color:#333;">
<span style="color:blue;">main</span>
  
    <span style="color:purple;">i_num1</span>, <span style="color:purple;">i_num2</span>;
    <span style="color:purple;">i_num1</span>, <span style="color:purple;">i_num2</span> = 10;
  
    <span style="color:green;">write</span>(<span style="color:purple;">i_num1</span>);
    <span style="color:blue;">repeat</span>
      <span style="color:purple;">i_num1</span> = <span style="color:purple;">i_num1</span> - 1;
      <span style="color:green;">write</span>(<span style="color:orange;">","</span>, <span style="color:purple;">i_num1</span>);
    <span style="color:blue;">while</span> <span style="color:purple;">i_num1</span> > 0;
  
    <span style="color:green;">writeln</span>(<span style="color:orange;">""</span>);
    <span style="color:green;">write</span>(<span style="color:purple;">i_num2</span>);
    <span style="color:blue;">repeat</span>
      <span style="color:purple;">i_num2</span> = <span style="color:purple;">i_num2</span> - 1;
      <span style="color:green;">write</span>(<span style="color:orange;">","</span>, <span style="color:purple;">i_num2</span>);
    <span style="color:blue;">until</span> <span style="color:purple;">i_num2</span> == 0;
  
    <span style="color:green;">writeln</span>(<span style="color:orange;">""</span>);
    <span style="color:green;">writeln</span>(<span style="color:orange;">"Programa Finalizado!"</span>);
  
<span style="color:blue;">end</span>
</pre>
