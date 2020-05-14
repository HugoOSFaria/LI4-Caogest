<template>
    <Horario :id="$route.params.id"/>
</template>

<script>
// @ is an alias to /src
import Horario from '@/components/Admin/HorarioCanil.vue'
export default {
  name: 'HorarioCanil',
  components: {
    Horario
  }
}
</script>