import { CameraView, useCameraPermissions } from "expo-camera"
import { useState } from "react"
import {
  Button,
  Text,
  TouchableOpacity,
  View,
  Image,
  ActivityIndicator,
} from "react-native"
import { useRouter } from "expo-router"
import { Ionicons } from "@expo/vector-icons"
import Logo from "../../assets/images/Logo-with-name.png"

const Camera = () => {
  const router = useRouter()
  const [loading, setLoading] = useState(false)
  const [scanned, setScanned] = useState(false)
  const [permission, requestPermission] = useCameraPermissions()
  const [flash, setFlash] = useState(false)

  if (!permission) {
    return <View />
  }

  if (!permission.granted) {
    return (
      <View className='flex-1 justify-center'>
        <Text className='text-center'>
          Chúng tôi cần quyền của bạn để sử dụng camera
        </Text>
        <Button onPress={requestPermission} title='Cho phép' />
      </View>
    )
  }

  const handleScanQR = (r) => {
    setScanned(true)
    setLoading(!loading)
  }

  return (
    <View className='relative flex-1'>
      <View
        className={`absolute left-0 top-0 z-20 flex-row items-center bg-transparent p-3 `}
      >
        <TouchableOpacity onPress={router.back}>
          <Ionicons name='arrow-back' size={24} color='white' />
        </TouchableOpacity>
        <View className='flex-1 items-center justify-center'>
          <Text className='mr-6 text-lg font-medium text-white'>
            Quét mã QR
          </Text>
        </View>
      </View>

      <View
        style={{ transform: [{ translateX: -45 }] }}
        className='absolute left-1/2 top-[90px] z-20'
      >
        <Image
          className='h-24 w-24 rounded-3xl object-cover'
          source={Logo}
        ></Image>
      </View>

      <TouchableOpacity
        style={{ transform: [{ translateX: -40 }] }}
        className={`${flash ? "bg-blue-500" : "bg-white"} \
        absolute bottom-[100px] left-1/2 z-20 rounded-full  p-5`}
        onPress={() => setFlash((prev) => !prev)}
      >
        <Ionicons name='flash' size={32} color={flash ? "white" : "#3b82f6"} />
      </TouchableOpacity>

      {loading && (
        <View
          className='absolute left-0 top-0 z-30 h-full w-full items-center 
            justify-center'
        >
          <View className='absolute left-0 top-0 h-full w-full bg-black opacity-30'></View>
          <ActivityIndicator size='large' color='#3b82f6' />
        </View>
      )}

      <CameraView
        className='flex-1 items-center justify-center'
        enableTorch={flash}
        onBarcodeScanned={scanned ? undefined : handleScanQR}
      >
        <View className='h-72 w-72 rounded-3xl border-[3px] border-white'></View>
      </CameraView>
    </View>
  )
}

export default Camera
