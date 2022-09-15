function get(url) {
  let request = new XMLHttpRequest();
  request.open("GET", url, false);
  request.send();
  return request.responseText;
}   

function makeLine(prod) {
    linha = document.createElement('tr')
    tdId =  document.createElement('td')
    tdNome =  document.createElement('td')
    tdId.innerHTML = prod.id
    tdNome.innerHTML = prod.modelo

    linha.appendChild(tdId);
    linha.appendChild(tdNome);

    return linha;

}

function main() {
  data = get("http://localhost:3001/roupas");
  telefones = JSON.parse(data);
  console.log(telefones)
  let table = document.getElementById('table')

  telefones.forEach((element) => {
    let line = makeLine(element);
    table.appendChild(line)
  });
}

main();
