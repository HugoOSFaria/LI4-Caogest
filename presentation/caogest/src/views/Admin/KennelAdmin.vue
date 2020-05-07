<template>
    <Kennel :id="$route.params.id"/>
</template>

<script>
// @ is an alias to /src
import Kennel from '@/components/Admin/KennelAdmin.vue'
export default {
  name: 'KennelsAdmin',
  components: {
    Kennel
  }
}
</script>