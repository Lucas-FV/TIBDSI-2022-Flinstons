const card = document.getElementById("card");

window.onload = () => {
  main();
};

function get(url) {
  let request = new XMLHttpRequest();
  request.open("GET", url, false);
  request.send();
  return request.responseText;
}


function main() {
  data = get("http://localhost:3001/livros");
  telefones = JSON.parse(data);
  console.log(telefones);
  card.innerHTML = "";

  telefones.forEach((element) => {
    let modelo = element.modelo;
    let preco = element.preco;
    let img = element.img;
    let link = element.link;
    let desc = element.desc;
    container = `
    <div id='sigle'>
          <p class="item-valor">${modelo}</p>
          <p class="item-valor">${preco}</p>
          <img id="img-size" src="${img}">
          <a href="${link}"> link da loja </a>

    </div>
    `;
    card.innerHTML += container
  });
}
