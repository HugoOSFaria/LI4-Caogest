<template>
    <div id = "volunteers" class = "Volunteers">
        <NavbarKennel :id="$route.params.id"/>
         <v-card> 
            <v-img src='@/assets/voluntarios.png'></v-img>
         </v-card>
        <Volunteers :id="$route.params.id"/>
        <Footer :id="$route.params.id"/>    
    </div>
</template>

<script>
import NavbarKennel from '@/components/NavbarFooter/NavbarKennel.vue'
import Footer from '@/components/NavbarFooter/FooterKennel.vue'
import Volunteers from '@/components/Volunteers.vue'
export default {
    components: {
        NavbarKennel, 
        Footer, 
        Volunteers
    }
};
</script>

<style>

</style>