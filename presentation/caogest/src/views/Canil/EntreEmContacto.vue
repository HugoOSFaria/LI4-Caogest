<template>
  <div id="entreemcontacto" class="entreemcontacto">
    <Navbar :ident="$route.params.ident" />
    <v-card>
      <v-img src="@/assets/entreemcontacto.png"></v-img>
    </v-card>
    <v-card flat height="150" color="white"></v-card>

    <EntreEmContacto :ident="$route.params.ident" />

    <v-btn
      v-scroll="onScroll"
      x-large
      v-show="fab"
      fab
      depressed
      fixed
      bottom
      right
      class = "ma-6"
      color="deep-orange lighten-4"
      @click="toTop"
    >
      <v-icon>keyboard_arrow_up</v-icon>
    </v-btn>    
    <Footer :ident="$route.params.ident"/>

  </div>
</template>

<script>

import Navbar from "@/components/NavbarFooter/NavbarKennel.vue";
import Footer from "@/components/NavbarFooter/FooterKennel.vue";
import EntreEmContacto from "@/components/Utilizador/EntreEmContacto.vue";


export default {
  
  data() {
    return {
      fab:false,
    };
  },
  methods: {
    onScroll (e) {
      if (typeof window === 'undefined') return
      const top = window.pageYOffset ||   e.target.scrollTop || 0
      this.fab = top > 20
    },
    toTop () {
      this.$vuetify.goTo(0)
    },
  },
  components: {
    Navbar,
    Footer,
    EntreEmContacto
  },

};
</script>

<style></style>