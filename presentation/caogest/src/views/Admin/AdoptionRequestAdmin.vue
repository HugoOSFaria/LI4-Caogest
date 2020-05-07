<template>
    <div id = "adoptionRequestAdmin" class = "Adoption Request Admin">
        <NavbarAdmin/>
        <v-card> 
            <v-img src='@/assets/pedidosadocao.png'></v-img> 
        </v-card>
       
        <v-container>
            <AdoptionRequestAdmin/>
        </v-container>
        <Footer/>
    </div>
</template>

<script>
import NavbarAdmin from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'
import AdoptionRequestAdmin from '@/components/Admin/AdoptionRequestAdmin.vue'
export default {
    components: { NavbarAdmin, 
                  Footer,
                  AdoptionRequestAdmin,
    }
}
</script>