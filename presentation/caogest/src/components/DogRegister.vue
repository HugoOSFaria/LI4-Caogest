<template>
    <div>
        <v-toolbar flat color="white" height=150px>
            <v-img src="@/assets/logoA5.png" max-height=150px max-width=150px></v-img>
        </v-toolbar>

    <v-row class="ma-2">
        <v-col>
        <v-card flat>
            <!-- Header -->
            <v-app-bar flat height=100px color="deep-orange lighten-4">
            <v-toolbar-title class="card-heading">Registar Cão</v-toolbar-title>
            </v-app-bar>
            <v-card flat height= "80" color = "white"></v-card>
            <!-- Content -->
            <v-container grid-list-md text-xl-left>
                <v-layout row wrap>
                <v-flex xs12>
                    <v-form ref="form" lazy-validation>
                        <v-card  flat>
                            <v-card-text>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">
                                            Nome
                                        </div>
                                        
                                        </v-col>
                                        <v-col>
                                            <v-text-field 
                                                rounded 
                                                outlined 
                                                placeholder="Introduza o nome"
                                                flat 
                                                color = "grey lighten-1" 
                                                required 
                                                v-model="form.nome"
                                                :rules="regraNome"
                                                name="nome"
                                                type="nome"
                                            ></v-text-field>
                                    </v-col>
                                </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">
                                            Raça
                                        </div>
                                    </v-col>
                                    <v-col>
                                        <v-text-field 
                                                rounded 
                                                outlined 
                                                placeholder="Introduza a raça"
                                                flat 
                                                color = "grey lighten-1" 
                                                required 
                                                v-model="form.raca"
                                                :rules="regraRaça"
                                                name="raca"
                                                type="raca"
                                            ></v-text-field>
                                    </v-col>
                                </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Idade</div>
                                    </v-col>
                                    <v-col>
                                        <v-text-field 
                                            rounded 
                                            outlined  
                                            placeholder="Introduza a idade"
                                            flat  
                                            color = "grey lighten-1"  
                                            required 
                                            v-model="form.idade"
                                            :rules="regraIdade"
                                            name="idade"
                                            type="number"
                                    ></v-text-field>
                                    </v-col>
                                </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Cor</div>
                                    </v-col>
            
                                    <v-col>
                                        <v-select 
                                            color = "grey"
                                            flat outlined 
                                            placeholder="Selecione a cor"
                                            :items="itemscor"
                                            multiple
                                            rounded
                                            v-model="form.cor"
                                            :rules="regraCor"
                                            name="cor"
                                            type="cor"
                                        ></v-select>
                                    </v-col>
                                </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Porte</div>
                                    </v-col>
            
                                    <v-col>
                                        <v-select 
                                            color = "grey"
                                            flat outlined 
                                            placeholder="Selecione o porte"
                                            :items="itemsporte"
                                            rounded
                                            v-model="form.porte"
                                            :rules="regraPorte"
                                            name="porte"
                                            type="porte"
                                        ></v-select>
                                    </v-col>
                                </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Sexo</div>
                                    </v-col>
                                    <v-col>
                                        <v-radio-group v-model="form.sexo" :rules="regraSexo" name="sexo" type="sexo" row>
                                            <v-radio label="Macho" value="Macho"></v-radio>
                                            <v-radio label="Fêmea" value="Fêmea"></v-radio>
                                        </v-radio-group>
                                    </v-col>
                                </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline">Esterilizado</div>
                                    </v-col>
                                    <v-col>
                                        <v-radio-group v-model="form.esterilizacao" :rules="regraEsterilizacao" name="esterilizacao" type="esterilizacao" row>
                                            <v-radio label="Sim" value="Sim"></v-radio>
                                            <v-radio label="Não" value="Não"></v-radio>
                                        </v-radio-group>
                                    </v-col>
                                </v-row>    
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline"> Notas Adicionais </div>
                                    </v-col>
                                    <v-col>
                                        <v-textarea
                                            v-model="form.descricao"
                                            name="descricao"
                                            type="descricao"
                                            flat
                                            outlined
                                            rounded
                                            auto-grow
                                            :rules="rules"
                                            placeholder = "Introduza informações que considere relevantes"
                                            color = "grey lighten-1" 
                                            rows = "5"
                                        ></v-textarea>
                                    </v-col>
                                </v-row>
                                <v-card flat height= "20" color = "white"></v-card>
                                <v-row>
                                    <v-col cols="2">
                                        <div class="info-label headline"> Fotografia </div>
                                    </v-col>
                                    <v-col>
                                        <v-file-input
                                            v-model="form.ficheiro"
                                            placeholder="Selecione o ficheiro a submeter"
                                            show-size
                                            clearable
                                            flat
                                            rounded
                                            single-line
                                            accept=".jpg, .jpeg, .png"
                                            outlined
                                            solo
                                            :rules="regraFicheiro"
                                        ></v-file-input>
                                    </v-col>
                                </v-row>

                            <v-row justify = "end">
                                <v-col cols = "12" md = "8">
                                    <v-row justify= "end">
                                        <v-btn class="ma-6" x-large color = "deep-orange lighten-4" @click="cancelar()" >Cancelar</v-btn>
                                        <v-btn class = "ma-6" x-large color = "deep-orange lighten-4" @click="registarCao()" >Registar</v-btn>
                                    </v-row>
                                </v-col>
                            </v-row>
                        </v-card-text>
                    </v-card>
                    </v-form>
                </v-flex>
                </v-layout>
                </v-container>
        </v-card>
        <div class="text-center ma-2">
            <v-snackbar
            v-model="snackbar"
            :color="color"
            :timeout="timeout"
            bottom
            multi-line
            class = "headline"
            >
            {{ text }}
            <v-btn class = "headline" text @click="fecharSnackbar">Fechar</v-btn>
            </v-snackbar>
            </div>
        </v-col>
    </v-row>
  </div>
</template>

<script>
import axios from 'axios'
const lhost = require("@/config/global").host;

export default {
    name: "signupdog",
    props:['id'],
    data: () => ({  
        itemsporte: [ 
            'Pequeno',
            'Médio',
            'Grande',
        ], 
        itemscor: [
            'Amarelo',
            'Azul',
            'Branco',
            'Castanho',
            'Cinzento',
            'Creme',
            'Dourado',
            'Fulvo',
            'Malhado',
            'Preto',
            'Vermelho',
        ],
        regraNome: [v => !!v || "Nome obrigatório."],
        regraRaça:[v => !!v || "Raça obrigatória."], 
        regraIdade: [v => !!v || "Idade obrigatória."],
        regraSexo: [v => !!v || "Género obrigatório."],
        regraEsterilizacao: [v => !!v || "Esterilização obrigatória."],
        regraCor: [v => !!v || "Cor obrigatória."],
        regraPorte: [v => !!v || "Porte obrigatório."],
        regraFicheiro: [v => !!v || "Selecione um ficheiro."],
        rules: [v => v.length <= 100 || 'Máx 100 caracteres'],
        form: {
            nome: "",
            raca: "", 
            idade: "", 
            sexo: "", 
            esterilizacao: "", 
            cor: "", 
            porte: "", 
            descricao:"",
            estado: "Por Adotar",
            canil_user_email:"", 
            ficheiro: null,
        },  
        snackbar: false, 
        color: "", 
        done: false, 
        timeout: 0,
        text: "", 

    }), 
    methods: {
      registarCao: async function(){
     
        if (this.$refs.form.validate()) {
            try{ 
                var formData = new FormData();
                if (this.form.ficheiro != null) {
                    formData.append("file", this.form.ficheiro);
                }
                var resposta = 
                    await axios.post(lhost + "/api/Caes/", {
                        nome: this.form.nome,
                        sexo: this.form.sexo, 
                        descricao: this.form.descricao,
                        estado: "Por Adotar",
                        raca: this.form.raca, 
                        cor: this.form.cor, 
                        idade: this.form.idade, 
                        esterilizacao: this.form.esterilizacao, 
                        porte: this.form.porte, 
                        canil_user_email: this.id,
                        file: formData,
                        path: this.form.ficheiro.name,
                    }); 
                    console.log(JSON.stringify(resposta.data));
                    this.text = "Cão registado com sucesso!";
                    this.color = "success"; 
                    this.snackbar = true; 
            }
            catch(e){
                console.log("erro: " + e);
                this.text = "Ocorreu um erro no registo, por favor tente mais tarde!";
                this.color = "warning"; 
                this.snackbar = true; 
            }
        } else {
            this.text = "Por favor preencha todos os campos!";
            this.color = "error";
            this.snackbar = true;
            this.done = false;
        }
    },

    fecharSnackbar() {
      this.snackbar = false;
      if(this.color == 'success')
        this.$router.push("/pagina/canil/" + this.id);
    },
    cancelar() {
      this.$router.push("/pagina/canil/" + this.id);
    },

    }
 
}
</script>

<style scoped>

.card-heading {
  font-size: x-large;
  font-weight: bold;
}
.info-label {
  color: "grey lighten-1"; 
  padding: 2px;
  font-weight: 500;
  width: 100%;
  background-color: "transparent";
  font-weight: bold;
  margin: 20px;
  border-radius: 50x;
}
</style>