---


---

<h1 id="tarea-2-y-3-9712370">Tarea 2 y 3 9712370</h1>
<p>Tarea 2 y 3<br>
Carné: 199712370<br>
Nombre: Juan Carlos Maeda Juárez<br>
Objetivo de la tarea:<br>
Realizar una aplicación SOA para simular los servicios de carros tipo Uber:</p>
<ol>
<li>Solicitud de servicio por parte del cliente</li>
<li>Recepción de solicitud y aviso al piloto</li>
<li>Solicitud de ubicación (rastreo) desde la administración del servicio de carros</li>
</ol>
<h1 id="solución">Solución</h1>
<h2 id="los-webservices-creados-son">Los WebServices creados son:</h2>
<ul>
<li>WSCLiente<br>
- SolicitarServicio</li>
<li>WSPiloto
<ul>
<li>EnviarCarrera</li>
<li>Diponibilidad</li>
</ul>
</li>
<li>WSRastreador</li>
<li>WSOrquestador</li>
</ul>
<h2 id="descripcion-de-metodos">Descripcion de metodos</h2>
<p>En el WScliente<br>
El metodo SolicitarServicio recibe como parametro el cliente para identificar.</p>
<p>En el WSPiloto<br>
El metodo EnviarCarrera recibe tres parametros, el primero el nombre del piloto, el nombre del cliente y la direccion destino.<br>
Diponibilidad recibe como parametro el nombre del piloto y devuelve si esta libre o no.</p>
<h2 id="diagrama-uml">Diagrama UML</h2>
<p>Diagrama de Secuencia</p>
<div class="mermaid"><svg xmlns="http://www.w3.org/2000/svg" id="mermaid-svg-VUtRGtJKHtgYYgaL" height="100%" width="100%" style="max-width:850px;" viewBox="-50 -10 850 371"><g></g><g><line id="actor1838" x1="75" y1="5" x2="75" y2="360" class="actor-line" stroke-width="0.5px" stroke="#999"></line><rect x="0" y="0" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="75" y="32.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="75" dy="0">Cliente</tspan></text></g><g><line id="actor1839" x1="275" y1="5" x2="275" y2="360" class="actor-line" stroke-width="0.5px" stroke="#999"></line><rect x="200" y="0" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="275" y="32.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="275" dy="0">ESB</tspan></text></g><g><line id="actor1840" x1="475" y1="5" x2="475" y2="360" class="actor-line" stroke-width="0.5px" stroke="#999"></line><rect x="400" y="0" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="475" y="32.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="475" dy="0">Piloto</tspan></text></g><g><line id="actor1841" x1="675" y1="5" x2="675" y2="360" class="actor-line" stroke-width="0.5px" stroke="#999"></line><rect x="600" y="0" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="675" y="32.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="675" dy="0">Rastreador</tspan></text></g><defs><marker id="arrowhead" refX="5" refY="2" markerWidth="6" markerHeight="4" orient="auto"><path d="M 0,0 V 4 L6,2 Z"></path></marker></defs><defs><marker id="crosshead" markerWidth="15" markerHeight="8" orient="auto" refX="16" refY="4"><path fill="black" stroke="#000000" stroke-width="1px" d="M 9,2 V 6 L16,4 Z" style="stroke-dasharray: 0, 0;"></path><path fill="none" stroke="#000000" stroke-width="1px" d="M 0,1 L 6,7 M 6,1 L 0,7" style="stroke-dasharray: 0, 0;"></path></marker></defs><g><text x="175" y="93" class="messageText" style="text-anchor: middle;">Pide un servicio?</text><line x1="75" y1="100" x2="275" y2="100" class="messageLine0" stroke-width="2" stroke="black" marker-end="url(#arrowhead)" style="fill: none;"></line></g><g><text x="375" y="128" class="messageText" style="text-anchor: middle;">Pregunta si el piloto esta disponible?</text><line x1="275" y1="135" x2="475" y2="135" class="messageLine0" stroke-width="2" stroke="black" marker-end="url(#arrowhead)" style="fill: none;"></line></g><g><text x="375" y="163" class="messageText" style="text-anchor: middle;">Retorna Disponiblidad!</text><line x1="475" y1="170" x2="275" y2="170" class="messageLine0" stroke-width="2" stroke="black" marker-end="url(#arrowhead)" style="fill: none;"></line></g><g><text x="475" y="198" class="messageText" style="text-anchor: middle;">Pregunta por la ubicacion del Piloto?</text><line x1="275" y1="205" x2="675" y2="205" class="messageLine0" stroke-width="2" stroke="black" marker-end="url(#arrowhead)" style="fill: none;"></line></g><g><text x="475" y="233" class="messageText" style="text-anchor: middle;">Devuelve ubicacion del piloto!</text><line x1="675" y1="240" x2="275" y2="240" class="messageLine0" stroke-width="2" stroke="black" marker-end="url(#arrowhead)" style="fill: none;"></line></g><g><text x="175" y="268" class="messageText" style="text-anchor: middle;">Confirma el servicio!</text><line x1="75" y1="275" x2="275" y2="275" class="messageLine0" stroke-width="2" stroke="black" marker-end="url(#arrowhead)" style="fill: none;"></line></g><g><rect x="0" y="295" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="75" y="327.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="75" dy="0">Cliente</tspan></text></g><g><rect x="200" y="295" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="275" y="327.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="275" dy="0">ESB</tspan></text></g><g><rect x="400" y="295" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="475" y="327.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="475" dy="0">Piloto</tspan></text></g><g><rect x="600" y="295" fill="#eaeaea" stroke="#666" width="150" height="65" rx="3" ry="3" class="actor"></rect><text x="675" y="327.5" dominant-baseline="central" alignment-baseline="central" class="actor" style="text-anchor: middle;"><tspan x="675" dy="0">Rastreador</tspan></text></g></svg></div>
<pre><code></code></pre>

