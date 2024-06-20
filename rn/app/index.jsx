import { ScrollView, View } from "react-native"
import { SafeAreaView } from "react-native-safe-area-context"
import LogoWithName from "../assets/images/Logo-with-name.png"
import * as Animatable from "react-native-animatable"
import { useRouter } from "expo-router"
import { useEffect } from "react"

export default function App() {
  const router = useRouter()

  useEffect(() => {
    setTimeout(() => {
      router.replace("(page)/Post_List/post-list")
    }, 3000)
  })

  return (
    <SafeAreaView className='h-full bg-white'>
      <ScrollView contentContainerStyle={{ height: "100%" }}>
        <View className=' h-full w-full items-center justify-center'>
          <Animatable.Image
            animation='bounceIn'
            duration={1000}
            easing='ease-in-out'
            className='h-72 w-72'
            source={LogoWithName}
          />
        </View>
      </ScrollView>
    </SafeAreaView>
  )
}
