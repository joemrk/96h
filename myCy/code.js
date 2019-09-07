
let url = 'http://62.80.185.165:3636/api/Dossier/38649263'
$.get(url, function(data){
console.log(data)
})


let da =
{
  COMPANY: {
    name: 'ТОВ \" ЮФ \"ДЕЛЬТА М\" ',
    edrpou: '38649263'
  },
  DIRECTOR: {
    children: [
      {
        name: 'ТОВ \"ДЕЛЬТА М ІНТЕРНЕШНЛ\"',
        edrpou: '41817167',
        status: 'director'
      },
      {
        name: 'ТОВ \"ДЕЛЬТА М ЮКРЕЙН\"',
        edrpou: '40019394',
        status: 'director'
      },
      {
        name: 'ТОВ \"КЛЕВЕР АГРО ТРЕЙД\"',
        edrpou: '39625710',
        status: 'director'
      },
      {
        name: 'ТОВ \"СЕЙВ КОМПАНІ\"',
        edrpou: '38898107',
        status: 'director'
      },
    ],
    name: 'ОВІНОВ ВАЛЕРІЙ ВАЛЕРІЙОВИЧ'
  },
  FOUNDERS: [
    {
      children: [
        {
          name: 'ЖБК \"ІЛЛІЧІВСЬКИЙ ПОРТОВИК-1\"',
          edrpou: '22490080',
          status: 'director'
        }
      ],
      name: 'ІВАНЬКО ІРИНА ОЛЕКСАНДРІВНА'
    }
  ]
}


function getElementsByObject(dataObj) {
  let arr = []

  arr.push({ group: 'nodes', data: { id: dataObj.COMPANY.name, edrpou: dataObj.COMPANY.edrpou, nodeType: 'company-node' } })
  arr.push({ group: 'nodes', data: { id: dataObj.DIRECTOR.name, name: dataObj.DIRECTOR.name, nodeType: 'director-node' } })
  arr.push({ group: 'edges', data: { id: dataObj.DIRECTOR.name + dataObj.COMPANY.name, source: dataObj.COMPANY.name, target: dataObj.DIRECTOR.name, edgeType: 'director-company-edge' } })

  for (let j = 0; j < dataObj.DIRECTOR.children.length; j++) {
    arr.push({ group: 'nodes', data: { id: dataObj.DIRECTOR.children[j].name, edrpou: dataObj.DIRECTOR.children[j].edrpou, nodeType: 'child-company-node' } })
    arr.push({ group: 'edges', data: { id: dataObj.DIRECTOR.children[j].name + dataObj.DIRECTOR.name, source: dataObj.DIRECTOR.children[j].name, target: dataObj.DIRECTOR.name, edgeType: 'director-company-edge' } })
  }

  for (let i = 0; i < dataObj.FOUNDERS.length; i++) {
    arr.push({ group: 'nodes', data: { id: dataObj.FOUNDERS[i].name, nodeType: 'founder-node' } })
    arr.push({ group: 'edges', data: { id: dataObj.FOUNDERS[i].name + dataObj.COMPANY.name, source: dataObj.COMPANY.name, target: dataObj.FOUNDERS[i].name, edgeType: 'founder-company-edge' } })
    for (let j = 0; j < dataObj.FOUNDERS[i].children.length; j++) {
      arr.push({ group: 'nodes', data: { id: dataObj.FOUNDERS[i].children[j].name, edrpou: dataObj.FOUNDERS[i].children[j].edrpou, nodeType: 'child-company-node' } })
      arr.push({ group: 'edges', data: { id: dataObj.FOUNDERS[i].children[j].name + dataObj.FOUNDERS[i].children[j].name, target: dataObj.FOUNDERS[i].name, source: dataObj.FOUNDERS[i].children[j].name, edgeType: 'director-company-edge' } })
    }
  }
  return arr
}

let cy = cytoscape({

  container: $('#cy'),

  elements: getElementsByObject(da),

  style: [
    {
      selector: 'node',
      style: {
        'background-height': '60%',
        'background-width': '60%',
        'border-width': 2,
        'border-style': 'solid',
        'border-color': '#ffffff',
        'label': 'data(id)',
      }
    },
    {
      selector: 'edge',
      style: {
        'curve-style': 'bezier',
        'width': '3',
      }
    },
    {
      selector: ".top-right",
      style: {
        "text-valign": "top",
        "text-halign": "right",
        //  'text-background-color':'#000',
        'text-background-opacity': '.3',
        'text-background-padding': '3'
      }
    },
    {
      selector: "node[nodeType = 'company-node']",
      style: {
        'background-image': 'img/company-white.png',
        'width': 50,
        'height': 50,
        'background-color': '#93538C',
        'label': 'data(id)'
      }
    },
    {
      selector: "node[nodeType = 'child-company-node']",
      style: {
        'background-image': 'img/company-white.png',
        'width': 30,
        'height': 30,
        'background-color': '#93538C',
      }
    },
    {
      selector: "node[nodeType = 'director-node']",
      style: {
        'background-image': 'img/director-white.png',
        'width': 40,
        'height': 40,
        'background-color': '#4285F4',
      }
    },
    {
      selector: "node[nodeType = 'founder-node']",
      style: {
        'background-image': 'img/founder-white.png',
        'width': 40,
        'height': 40,
        'background-color': '#22B473',
      }
    },

    {
      selector: 'edge[edgeType="director-company-edge"]',
      style: {
        'line-fill': 'linear-gradient',
        'line-gradient-stop-colors': '#93538C #4285F4',
      }
    },
    {
      selector: 'edge[edgeType="founder-company-edge"]',
      style: {
        'line-fill': 'linear-gradient',
        'line-gradient-stop-colors': '#93538C #22B473',
      }
    }
  ],
  layout: {
    name: 'cose-bilkent',
    idealEdgeLength: 250,
    padding: 200
  }
})

cy.center()

// cy.on('tap', 'node', function (evt) {
//   var node = evt.target;
//   console.log(node.edrpou());
// });