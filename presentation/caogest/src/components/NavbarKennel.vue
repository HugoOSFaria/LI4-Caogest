<template>
    <div id="app">
        <nav>
            <v-app-bar flat app height = "100" color="deep-orange lighten-4">
                <v-app-bar-nav-icon class = "black--text" @click="drawer = !drawer"></v-app-bar-nav-icon>
                <v-app-bar flat color = "deep-orange lighten-4" class = "text-uppercase black--text">
                    <span class= "font-weight-light">Cao</span>
                    <span>Gest</span>
                </v-app-bar>
                <v-spacer></v-spacer>
                <v-btn text to = "/">
                    <span>Terminar Sessão</span>
                    <v-icon right>exit_to_app</v-icon>
                </v-btn>
            </v-app-bar>
            <v-layout align-center justify-space-between column fill-height>
            <v-navigation-drawer app v-model="drawer" class = "white" width = "400">
            <v-list-item two-line>
                <v-list-item-avatar>
                <v-icon>account_circle</v-icon>
                </v-list-item-avatar>

                <v-list-item-content>
                <v-list-item-title>Nome Utilizador</v-list-item-title>
                </v-list-item-content>
            </v-list-item>

        <v-divider></v-divider>

        <v-list nav> 
            <v-list-item 
                v-for="item in items"
                :key="item.title"
                router :to="item.route"
                link
            >
                <v-list-item-icon>
                    <v-icon class = "ma-2">{{ item.icon }}</v-icon>
                </v-list-item-icon>

                <v-list-item-content>
                    <v-list-item-title>{{ item.title }}</v-list-item-title>
                </v-list-item-content>
                <v-card height = "20" flat></v-card>
            </v-list-item>
        </v-list>
        <template v-slot:append>
        <div class="pa-2">
            <v-btn x-large text block to='/preferencesKennel'>
                <v-icon left>settings</v-icon>Preferências
            </v-btn>
        </div>
      </template>

        </v-navigation-drawer>
        </v-layout>
    </nav>
</div>

</template>

<script>
export default {
    data() {
        return {
            drawer: true,
            items: [
            { title: 'Página Inicial', icon: 'dashboard', route: '/mainpagekennel'}, 
            { title: 'Pedidos de Adoção', icon: 'description', route: '/adoptionrequest'},
            { title: 'Sobre', icon: 'info', route: '/sobre1' },
            { title: 'Donativos', icon: 'payment', route: '/donations'},
            { title: 'Horários', icon: 'schedule', route: '/schedule' },
            { title: 'Voluntários', icon: 'people', route: '/voluntarios' },
            { title: 'Parcerias', icon: 'group_work', route: '/partnerships' },
            { title: 'FAQs', icon: 'help', route: '/faqskennel' }
            ],
        }
    }
}
</script>

<style>
</style>