<template>
  <div id="adoptionrequest">
    <v-card flat height="80" color="white"></v-card>
    <p class="my-5 display-2 font-weight-bold text-center">Pedidos Registo de Canil</p>
    <v-card flat height="40" color="white"></v-card>

    <v-container class="my-5">

        <v-layout row class="mb-3"> 
            <v-tooltip top>
                <template v-slot:activator="{ on }">
                    <v-btn class = "ma-2" color="grey" @click="sortBy('title')" v-on="on">
                        <v-icon left small>person</v-icon>    
                        <span class = "caption text-lowercase">Por nome de canil</span>
                    </v-btn>  
                </template>
                <span>Ordenar pedidos por nome de canil</span> 
            </v-tooltip>

            <v-tooltip top>    
                <template v-slot:activator="{ on }">
                    <v-btn class = "ma-2" color="grey" @click="sortBy('person')" v-on="on">
                        <v-icon left small>today</v-icon>    
                        <span class = "caption text-lowercase">Por data</span>
                    </v-btn> 
                </template>
                <span>Ordenar pedidos por data de submissão</span>
            </v-tooltip>    
        </v-layout>

      <v-card flat v-for="project in projects" :key="project.title">
        <v-layout row wrap :class="`pa-7 project ${project.status}`">
          <v-flex xs12 md6>
            <div class="caption grey--text">Nome do Canil</div>
            <div>{{ project.title }}</div>
          </v-flex>
          
          <v-flex xs6 sm4 md2>
            <div class="caption grey--text">Data de Submissão</div>
            <div>{{ project.due }}</div>
          </v-flex>
          <v-flex xs2 sm4 md2>
               <v-chip :color="project_status(project.status)" class="white--text caption my-2">{{project.status}}</v-chip> 
            <div>
            </div>
          </v-flex>
        </v-layout>
        <v-divider></v-divider>
      </v-card>
    </v-container>
  </div>
</template>

<script>
export default {
  data() {
    return {
      projects: [
        { title: 'Design a new website', person: 'The Net Ninja', due: '1st Jan 2017', status: 'rejeitado', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt consequuntur eos eligendi illum minima adipisci deleniti, dicta mollitia enim explicabo fugiat quidem ducimus praesentium voluptates porro molestias non sequi animi!'},
        { title: 'Code up the homepage', person: 'Chun Li', due: '10th Jan 2019', status: 'aceite', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt consequuntur eos eligendi illum minima adipisci deleniti, dicta mollitia enim explicabo fugiat quidem ducimus praesentium voluptates porro molestias non sequi animi!'},
        { title: 'Design video thumbnails', person: 'Ryu', due: '20th Dec 2018', status: 'pendente', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt consequuntur eos eligendi illum minima adipisci deleniti, dicta mollitia enim explicabo fugiat quidem ducimus praesentium voluptates porro molestias non sequi animi!'},
        { title: 'Create a community forum', person: 'Gouken', due: '20th Oct 2018', status: 'expirado', content: 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt consequuntur eos eligendi illum minima adipisci deleniti, dicta mollitia enim explicabo fugiat quidem ducimus praesentium voluptates porro molestias non sequi animi!'},
      ]
    };
  },
  methods: {
    sortBy(prop){
          this.projects.sort((a,b) => a[prop] < b[prop] ? -1 : 1)
    },

    project_status(status) {
        if (status == "aceite") 
          return "#3cd1c2";
        else if (status == "pendente") 
          return "orange";
        else if (status == "expirado")
          return "purple";
        return "red";
    }
    }
};
</script>

<style>
.project.aceite {
  border-left: 4px solid #3cd1c2;
}

.project.pendente {
  border-left: 4px solid orange;
}

.project.expirado {
  border-left: 4px solid purple;
}

.project.rejeitado {
    border-left: 4px solid red;
}

</style>