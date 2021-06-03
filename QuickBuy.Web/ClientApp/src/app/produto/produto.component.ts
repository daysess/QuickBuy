import { Component } from "@angular/core"

@Component({
  selector: "produto",
  template: "<html><body>{{obterNome()}}</body></html>"
})
export class ProdutoComponent { // Nome das classes começando com maiusculo por conta da convenção PascalCase

  // camelCase para variáveis, atributos e nomes das funções
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung";
  }

}
