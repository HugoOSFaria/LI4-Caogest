<template>
    <div>
        <v-card> 
            <v-img src='@/assets/horários.png'>
            </v-img>
        </v-card>
        <v-card flat height= "100" color = "white"></v-card>

        <v-container>

            <v-card flat height= "100" color = "white"></v-card>

            <v-row>
                <v-col v-for="hor in sortedArray" :key = "hor.dia" cols="12" md="4" >
                    <v-card
                        color="white"
                        class="d-flex align-center"
                        dark
                        
                        height="400"
                    >
                        <v-col>
                            <v-row>
                                <v-flex xs12 text-xs-center>
                                    <div class = "text-center display-1 font-weight-bold black--text">{{dia(hor.dia)}}</div>
                                </v-flex>
                            </v-row>
                            
                            <v-card flat height= "30" color = "white"></v-card>
                            
                            <v-row>
                                <v-flex xs12 text-xs-center>
                                    <div class = "text-center headline black--text">{{date(hor.dataInicio)}} - {{date(hor.dataFim)}}</div>
                                </v-flex>    
                            </v-row>

                            <v-card flat height= "30" color = "white"></v-card>

                            <v-row align = "center" justify = "center">
                                    <v-chip color = "deep-orange lighten-4" class = "black--text">
                                        {{hor.registados}} Voluntários
                                    </v-chip>
                            </v-row>
                            <v-card flat color = "white" height = "40"></v-card>
                            <v-row align = "center" justify = "center">
                                <v-btn v-if="hor.registados !== 0" disabled class = "headline" light block>Editar Horário</v-btn>
                                <v-btn v-else class = "headline" color = "brown lighten-4" light block @click="editaHorario(hor)">Editar Horário</v-btn>
                            </v-row>
                        </v-col>
                    </v-card>
                </v-col>
            </v-row>
        </v-container>
        <v-dialog v-model="dialog" persistent width="1000px">
        <v-card class = "mx-auto" height = "400">
            <v-card color = "brown darken-4" flat dark class="pa-6" height="80">
                <span class="display-1" dark>Alterar Horário</span>
            </v-card>
            <v-card color = "white" fluid class = "mx-auto text-center px-12" flat>
            <v-card height = "30" flat ></v-card>
            <v-row>
                <v-col cols = "6">
                    <v-menu
                        ref="dataInicio7"
                        v-model="menu13"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        :return-value.sync="dataInicio7"
                        transition="scale-transition"
                        offset-y
                        max-width="290px"
                        min-width="290px"
                    >
                        <template v-slot:activator="{ on }">
                            <v-text-field
                                :rules="regraHorario"
                                label="Hora Início"
                                prepend-icon="access_time"
                                readonly
                                color = "grey"
                                v-on="on"
                                v-model="form.dataInicio7"
                            ></v-text-field>
                        </template>
                        <v-time-picker
                            format="24hr"
                            v-model="form.dataInicio7"
                            full-width
                            color = "brown lighten-2"
                            @click:minute="$refs.dataInicio7.save(dataInicio7)"
                        ></v-time-picker>
                    </v-menu>
                </v-col>
                                     
                <v-col cols = "6">
                    <v-menu
                        ref="dataFim7"
                        v-model="menu14"
                        :close-on-content-click="false"
                        :nudge-right="40"
                        :return-value.sync="dataFim7"
                        transition="scale-transition"
                        offset-y
                        max-width="290px"
                        min-width="290px"
                    >
                        <template v-slot:activator="{ on }">
                            <v-text-field
                                :rules="regraHorario"
                                label="Hora Fim"
                                prepend-icon="access_time"
                                readonly
                                color = "grey"
                                v-on="on"
                                v-model="form.dataFim7"
                            ></v-text-field>
                        </template>
                        <v-time-picker
                            format="24hr"
                            v-model="form.dataFim7"
                            full-width
                            color = "brown lighten-2"
                            @click:minute="$refs.dataFim7.save(dataFim7)"
                        ></v-time-picker>
                    </v-menu>
                </v-col>    
            </v-row>
            <v-card height = "80" flat></v-card>
            <v-row align = "end" justify = "end">
                <v-spacer></v-spacer>
                <v-btn class = "mr-2 headline" color="brown lighten-1" text @click="dialog = false">Cancelar</v-btn>
                <v-btn class = "mr-2 headline" color="brown lighten-1" text @click="confirma()">Confirmar</v-btn>
            </v-row>
            </v-card>
        </v-card>
    </v-dialog>
    </div>
</template>

<script>
import axios from 'axios'
import moment from 'moment/moment';
const lhost = require("@/config/global").host;


export default {
    name: 'Horario',
    props:['id'],
    data: () => ({             
        items: [],
        dialog: false,
        regraHorario: [v => !!v || "Horários obrigatórios."],
        dataInicio7:null, 
        dataFim7:null, 
        menu13:false, 
        menu14:false, 
        form:{
            dataInicio7:"", 
            dataFim7:"",
        }
    }),
    components: { },
    created: async function(){
        try {
            let response = await axios.get(lhost + "/api/Horarios/" + this.id);
            this.items = response.data;
            this.ready = true;
        } 
        catch (e) {
            return e;
        }
    },  
    methods: {
        date: function (date) {
            return moment(date).locale("pt").format('LT');
        },
        dia: function (num) {
            if(num === 1) return "Segunda-feira"
            else if (num === 2) return "Terça-feira";
            else if (num === 3) return "Quarta-feira"; 
            else if (num === 4) return "Quinta-feira"; 
            else if (num === 5) return "Sexta-feira"; 
            else if (num === 6) return "Sábado";
            return "Domingo";
        },
        editaHorario: function(dados){
            this.dataInicio7 = dados.dataInicio7;
            this.dataFim7 = dados.dataFim7;
            this.dialog = true;
        },
        confirma:  async function() {
            try{ 
                var resposta = 
                await axios.post(lhost + "/api/Canil/" + this.idCao , {
                    idCao:this.idCao,
                    nome:this.nome,
                    raca:this.raca,
                    idade:this.idade,
                    sexo:this.sexo,
                    cor:this.cor,
                    porte:this.porte,
                    esterilizacao:this.esterilizacao,
                    descricao:this.descricao,
                    estado:"Apagado",
                    canil_user_email:this.id
                });
                console.log(JSON.stringify(resposta.data));
                this.atualiza();
                this.dialog=false;
            }
            catch(e){
                console.log("erro: " + e); 
            }
        },
    },
    computed: {
        sortedArray: function() {
            function compare(a, b) {
            if (a.dia < b.dia)
                return -1;
            if (a.dia > b.dia)
                return 1;
            return 0;
            }

            return this.items.slice(0).sort(compare);
        }
    },     
}
</script>