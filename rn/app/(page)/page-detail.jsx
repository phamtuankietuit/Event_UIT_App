import {
  View,
  Text,
  Image,
  TouchableOpacity,
  ActivityIndicator,
  FlatList,
} from "react-native"
import { useState } from "react"

import MyHeader from "../components/MyHeader"
import EventItem from "../components/EventItem"

const PageDetail = () => {
  const [data, setData] = useState([
    { key: "1", text: "Item 1" },
    { key: "2", text: "Item 2" },
    { key: "3", text: "Item 3" },
    { key: "4", text: "Item 4" },
    { key: "5", text: "Item 5" },
    { key: "6", text: "Item 6" },
    { key: "7", text: "Item 7" },
    { key: "8", text: "Item 8" },
    { key: "9", text: "Item 9" },
    { key: "10", text: "Item 10" },
    { key: "11", text: "Item 11" },
    { key: "12", text: "Item 12" },
    { key: "13", text: "Item 13" },
    { key: "14", text: "Item 14" },
    { key: "15", text: "Item 15" },
    { key: "16", text: "Item 16" },
    { key: "17", text: "Item 17" },
    { key: "18", text: "Item 18" },
    { key: "19", text: "Item 19" },
    { key: "20", text: "Item 20" },
  ])

  const [isLoading, setIsLoading] = useState(false)
  return (
    <View className='relative flex-1'>
      <View className='absolute left-0 top-0 -z-10 h-[230px] w-full rounded-b-3xl bg-blue-500'></View>
      <MyHeader title={"Chi tiết trang"} />
      <View className='mx-auto mt-5 flex-row justify-center rounded bg-white p-3 shadow shadow-black'>
        <Image
          className='h-24 w-24 rounded-full'
          source={{
            uri: "https://scontent.fhan3-2.fna.fbcdn.net/v/t39.30808-1/433114130_831671392310356_5035585911249711009_n.jpg?stp=c22.22.196.196a_dst-jpg_p240x240&_nc_cat=101&ccb=1-7&_nc_sid=f4b9fd&_nc_eui2=AeHb8pLNemC1dQQ8Kc8wITERQ4fKu1Nmd3RDh8q7U2Z3dKPZ3dpL8PO8dSmz7BCZ83yxd3SNSsVqNxqfbVmbpZTG&_nc_ohc=PNKV0f_JwrQQ7kNvgH3PcR_&_nc_ht=scontent.fhan3-2.fna&oh=00_AYBfM5vEAocXFUrhcl4dq02HMCOmw2nVXKz2C6Iu0WMiYw&oe=66831C20",
          }}
        ></Image>
        <View className='ml-3'>
          <Text className='text-xl font-medium'>WebDev Studios</Text>
          <Text className=''>135 người theo dõi</Text>
          <TouchableOpacity className='mt-3 flex-row items-center justify-center rounded bg-blue-500 px-3 py-2'>
            <Text className='font-medium text-white'>Theo dõi</Text>
            {/* <ActivityIndicator size='small' color='#ffffff' /> */}
          </TouchableOpacity>
        </View>
      </View>

      <View className='mx-auto mt-2 min-w-[300px] max-w-[350px] items-center rounded bg-white p-3 shadow shadow-black'>
        <Text className='text-base font-medium'>Giới thiệu</Text>
        <Text numberOfLines={5} ellipsizeMode='tail'>
          WebDev Studios xin chào!
        </Text>
      </View>

      <View className='mt-3 flex-1'>
        {isLoading ? (
          <View className='h-full rounded-t-2xl bg-white px-3 py-2'>
            <ActivityIndicator size='large' color='#0000ff' />
          </View>
        ) : (
          <FlatList
            className='rounded-t-2xl bg-white px-3 py-2 pt-3 shadow shadow-black'
            data={data}
            keyExtractor={(item) => item.key}
            renderItem={({ item }) => <EventItem item={item} />}
            showsVerticalScrollIndicator={false}
            // refreshControl={
            //   <RefreshControl
            //     refreshing={refreshing}
            //     onRefresh={onRefresh}
            //     colors={["#3A57E8"]}
            //     tintColor='#3A57E8'
            //     progressViewOffset={20}
            //   />
            // }
            ListFooterComponent={<View className='mb-52'></View>}
          />
        )}
      </View>
    </View>
  )
}

export default PageDetail
