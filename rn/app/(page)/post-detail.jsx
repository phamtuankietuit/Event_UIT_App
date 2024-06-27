import { SafeAreaView } from "react-native-safe-area-context"
import {
  ScrollView,
  Text,
  TouchableOpacity,
  View,
  Image,
  Modal,
  FlatList,
} from "react-native"
import { AntDesign } from "@expo/vector-icons"
import { useSelector, useDispatch } from "react-redux"
import {
  setFullScreenImage,
  clearFullScreenImage,
} from "../redux/imageSlice"
import { Ionicons } from "@expo/vector-icons"
import { useNavigation } from "@react-navigation/native"

const avt = require("../../assets/images/Logo.png")
const images = [
  require("../../assets/images/img1.jpg"),
  require("../../assets/images/img2.jpg"),
  require("../../assets/images/img3.jpg"),
  require("../../assets/images/img4.jpg"),
  require("../../assets/images/img5.jpg"),
]

const PostDetail = () => {
  const fullScreenImage = useSelector((state) => state.image.fullScreenImage)
  const dispatch = useDispatch()

  const handleImagePress = (image) => {
    dispatch(setFullScreenImage(image))
  }

  const renderImageItem = ({ item }) => (
    <TouchableOpacity onPress={() => handleImagePress(item)}>
      <Image source={item} className='h-full w-[250]' resizeMode='contain' />
    </TouchableOpacity>
  )

  return (
    <SafeAreaView className='flex-1 bg-white'>
      <ScrollView>
        <View
          className='h-[46] w-full  flex-row items-center justify-between px-2'
          style={{ borderBottomWidth: 0.7 }}
        >
          <View className=' flex-row items-center '>
            <TouchableOpacity>
              <AntDesign name='left' size={15} color='#6F6A61' />
            </TouchableOpacity>
          </View>
          <View>
            <TouchableOpacity className=' rounded bg-blue-600 p-2'>
              <Text style={{ color: "white" }}>CHỈNH SỬA</Text>
            </TouchableOpacity>
          </View>
        </View>
        {/* khung avt */}
        <View className='py-[6] pl-1'>
          <View className='flex-row'>
            <View className='mr-1 h-[55] w-[55] rounded-full'>
              <Image
                source={avt}
                className='absolute h-full w-full rounded-full'
              ></Image>
            </View>
            <View className='justify-center'>
              <Text className=' text-base font-semibold'>Admin</Text>
              <Text className='text-xs'>22 thg 6</Text>
            </View>
          </View>
        </View>
        {/* Nội dung */}
        <View className='px-1'>
          <Text className='text-sm'>
            🔮 [CSAC Minigame] Đoán Tên Lá Bài - Vận Mệnh Hóa Giải 🔮 ☄️ Ngay
            lúc này, nó vẫn đang phát triển... chờ đợi... sôi sục bên dưới làn
            nước của cái hồ phản chiếu muôn ngàn ánh sao. ☯️ Bởi vì cuộc đời là
            những điều bất ngờ. Những kẻ biết nắm bắt vận mệnh, sẵn sàng đón
            nhận cơ hội mới là những kẻ thành công. Kẻ thức thời mới là trang
            tuấn kiệt. Nếu biết trước được vận mệnh trong tay, liệu bạn có dám
            thay đổi nó? 🃏 Nắm bắt vận mệnh, khai phá thiên cơ. Cùng nhau trở
            thành các Tarot Reader tập sự cùng CSAC để bắt đầu hành trình khai
            phá vận mệnh của bản thân thông qua chiếc Minigame này nhé. Và tất
            nhiên, những điều bất ngờ vẫn còn dài phía trước....
            ------------------------------------------------------------------------------------------------------
          </Text>
        </View>
        {/* View chứa ảnh */}
        <View className='h-[300] w-full flex-1 items-center px-1'>
          <FlatList
            data={images}
            renderItem={renderImageItem}
            keyExtractor={(item, index) => index.toString()}
            horizontal
            showsHorizontalScrollIndicator={false}
          />
        </View>
        {/* số ng tham gia */}
        <View className='mt-2 py-[3] pl-2' style={{ borderTopWidth: 0.5 }}>
          <View className='w-[180] flex-row items-center justify-center rounded-xl bg-slate-200 py-2'>
            <Ionicons name='people' size={24} color='gray' />
            <Text className='ml-1 flex-shrink'>Đã tham gia:</Text>
            <Text className='flex-shrink'> 30</Text>
          </View>
        </View>
      </ScrollView>
      {/* Modal xem ảnh toàn màn hình */}
      {fullScreenImage && (
        <Modal
          visible={true}
          transparent={true}
          onRequestClose={() => dispatch(clearFullScreenImage())}
        >
          <View className='h-full w-full flex-1 bg-black'>
            <TouchableOpacity onPress={() => dispatch(clearFullScreenImage())}>
              <Image
                source={fullScreenImage}
                className='h-full w-full'
                resizeMode='contain'
              />
            </TouchableOpacity>
          </View>
        </Modal>
      )}
    </SafeAreaView>
  )
}

export default PostDetail
